	
[](#L-259)	[](#L-260)	\-- support index.name and index\_name:
	[](#L-261)	\-- 1.2.group / 1.2\_group to 1.2:group
	[](#L-262)	s \= s:gsub('^(\[%d%.\]+)\[%.\_\]%f\[%l\]', '%1:')
	
[](#L-263)	[](#L-264)	\-- now the key should be in normalized form, if the origin key is vaild
[](#L-265)	[](#L-266)	\-- standardize \*\_css to \*\_style
	[](#L-267)	s \= s:gsub('\_css$', '\_style')
	[](#L-268)	\-- standardize \*collapsible to \*state
	[](#L-269)	s \= s:gsub('collapsible$', 'state')
[](#L-270)	[](#L-271)	\-- standardize all aliases to the canonical name
	[](#L-272)	return CANONICAL\_NAMES\[s\] or s
[](#L-273)end
[](#L-274)[](#L-275)function h.normalizeValue(k, v)
	[](#L-276)	k \= tostring(k)
	[](#L-277)	if k:find('\_style$') then
		[](#L-278)		v \= (v .. ';'):gsub(';;', ';')
		[](#L-279)		return v
	[](#L-280)	elseif k:find('state$') then
		[](#L-281)		return STATES\[v\]
	[](#L-282)	elseif k \== 'striped' then
		[](#L-283)		return STRIPED\[v\]
	[](#L-284)	elseif k \== 'meta' then
		[](#L-285)		return not BOOL\_FALSE\[v\]
	[](#L-286)	elseif v:sub(1, 2) \== '{|' or v:match('^\[\*:;#\]') then
		[](#L-287)		\-- Applying nowrap to lines in a table does not make sense.
		[](#L-288)		\-- Add newlines to compensate for trim of x in |parm=x in a template.
		[](#L-289)		return '\\n' .. v ..'\\n'
	[](#L-290)	end
	[](#L-291)	return v
[](#L-292)end
[](#L-293)[](#L-294)\-- parse arguments, convert them to structured data tree
[](#L-295)function h.buildDataTree(args)
	[](#L-296)	\-- parse args to a tree
	[](#L-297)	local tree \= h.buildTree(args)
[](#L-298)	[](#L-299)	\-- build root navbox data
	[](#L-300)	local data \= h.buildNavboxData(tree.info)
	
[](#L-301)	[](#L-302)	\-- Recursively build section tree
	[](#L-303)	if tree.children then
		[](#L-304)		data.sections \= h.buildSections(tree.children, {
			[](#L-305)			listClass \= h.mergeAttrs(args.list\_class, config.default\_list\_class),
			[](#L-306)			listStyle \=  args.list\_style,
			[](#L-307)			groupClass \= h.mergeAttrs(args.group\_class, config.default\_group\_class),
			[](#L-308)			groupStyle \= args.group\_style,
			[](#L-309)			sectionClass \= h.mergeAttrs(args.section\_class, config.default\_section\_class),
			[](#L-310)			sectionStyle \= args.section\_style,
			[](#L-311)			headerClass \= h.mergeAttrs(args.header\_class, config.default\_header\_class),
			[](#L-312)			headerStyle \= args.header\_style,
			[](#L-313)			headerState \= args.header\_state or config.default\_header\_state,
		[](#L-314)		})
	[](#L-315)	end
	[](#L-316)	if args\[1\] \== 'child' then
		[](#L-317)		data.CHILD\_MODE \= true
	[](#L-318)	end
[](#L-319)	[](#L-320)	return data
[](#L-321)end
[](#L-322)[](#L-323)function h.buildSections(list, defaults)
	[](#L-324)	local sections \= {}
	[](#L-325)	local section \= nil
	[](#L-326)	for k, node in h.orderedPairs(list) do
		[](#L-327)		local info \= node.info or {}
		[](#L-328)		\--start a new section if needed
		[](#L-329)		if info.header or not section then
			[](#L-330)			section \= { 
				[](#L-331)				class \= h.mergeAttrs(info.section\_class, defaults.sectionClass),
				[](#L-332)				style \= h.mergeAttrs(info.section\_style, defaults.sectionStyle),
				[](#L-333)				body \= {}
			[](#L-334)			}
			[](#L-335)			\-- Section header if needed.
			[](#L-336)			\-- If the value of a \`|header\_n=\` is two or more consecutive "-" characters (e.g. --, -----), 
			[](#L-337)			\-- it means start a new section without header, and the new section will be not collapsable.
			[](#L-338)			if info.header and not string.match(info.header, '^%-%-+$') then
				[](#L-339)				section.header \= {
					[](#L-340)					content \= info.header,
					[](#L-341)					class \= h.mergeAttrs(info.header\_class, defaults.headerClass),
					[](#L-342)					style \= h.mergeAttrs(info.header\_style, defaults.headerStyle),
				[](#L-343)				}
				[](#L-344)				section.state \= info.state or defaults.headerState or 'mw-collapsible'
			[](#L-345)			end
			[](#L-346)			sections\[#sections+1\] \= section
		[](#L-347)		end
		[](#L-348)		\-- above/below for this section
		[](#L-349)		if info.above then
			[](#L-350)			section.above \= {
				[](#L-351)				content \= info.above,
				[](#L-352)				class\= h.mergeAttrs(info.above\_class, config.default\_above\_class),
				[](#L-353)				style \= info.above\_style,
			[](#L-354)			}
		[](#L-355)		end
		[](#L-356)		if info.below then
			[](#L-357)			section.below \= {
				[](#L-358)				content \= info.below,
				[](#L-359)				class\= h.mergeAttrs(info.below\_class, config.default\_below\_class),
				[](#L-360)				style \= info.below\_style,
			[](#L-361)			}
		[](#L-362)		end
		[](#L-363)		\-- this group+list row
		[](#L-364)		if info.group or info.list or node.children then
			[](#L-365)			local row \= {}
			[](#L-366)			section.body\[#section.body+1\] \= row
			[](#L-367)			if info.group then
				[](#L-368)				row.group \= {
					[](#L-369)					content \= info.group,
					[](#L-370)					class \= h.mergeAttrs(info.group\_class, defaults.groupClass),
					[](#L-371)					style \= h.mergeAttrs(info.group\_style, defaults.groupStyle),
				[](#L-372)				}
			[](#L-373)			end
			[](#L-374)			if info.list then
				[](#L-375)				if string.sub(info.list, 1, NAVBOX\_CHILD\_INDICATOR\_LENGTH) \== NAVBOX\_CHILD\_INDICATOR then
					[](#L-376)					\-- it is from {{[navbox](https://spaceengineers.wiki.gg/wiki/Template:Navbox "Template:Navbox")|child| ... }}
					[](#L-377)					row.sections \= mw.text.jsonDecode(string.sub(info.list, NAVBOX\_CHILD\_INDICATOR\_LENGTH+1))
				[](#L-378)				else
					[](#L-379)					row.list \= {
						[](#L-380)						content \= info.list,
						[](#L-381)						class \= h.mergeAttrs(info.list\_class, defaults.listClass),
						[](#L-382)						style \= h.mergeAttrs(info.list\_style, defaults.listStyle),
					[](#L-383)					}
				[](#L-384)				end
			[](#L-385)			end
			[](#L-386)			\-- sub-nodes, will override {{[navbox](https://spaceengineers.wiki.gg/wiki/Template:Navbox "Template:Navbox")|child| ... }}
			[](#L-387)			if node.children then
				[](#L-388)				row.sections \= h.buildSections(node.children, defaults)
			[](#L-389)			end
		[](#L-390)		end
	[](#L-391)	end
	[](#L-392)	\-- flatten if needed:
	[](#L-393)	\-- If a section has only one list with no content and no corresponding group but has sublists, these sublists will be moved to upper level.
	[](#L-394)	if config.auto\_flatten\_top\_level then
		[](#L-395)		for \_, sect in ipairs(sections) do
			[](#L-396)			if #sect.body \== 1 then
				[](#L-397)				local node \= sect.body\[1\]
				[](#L-398)				if not node.group and not node.list and node.sections and #node.sections \== 1 and not node.sections\[1\].header then
					[](#L-399)					sect.body \= node.sections\[1\].body
				[](#L-400)				end
			[](#L-401)			end
		[](#L-402)		end
	[](#L-403)	end
	[](#L-404)	return sections
[](#L-405)end
	
[](#L-406)[](#L-407)function h.buildNavboxData(info)
	[](#L-408)	local data \= {
		[](#L-409)		state \= info.state or 'mw-collapsible', \-- here we need a default value for empty input
		[](#L-410)		striped \= info.striped,
		[](#L-411)		class \= h.mergeAttrs(info.navbox\_class, config.default\_navbox\_class),
		[](#L-412)		style \= info.navbox\_style,
	[](#L-413)	}
	
[](#L-414)	[](#L-415)	\-- data for titlebar
	[](#L-416)	if info.title or info.meta or data.state ~= '' then
		[](#L-417)		data.title \= {
			[](#L-418)			content \= info.title,
			[](#L-419)			class \= h.mergeAttrs(info.title\_class, config.default\_title\_class),
			[](#L-420)			style \= info.title\_style,
		[](#L-421)		}
		[](#L-422)		if info.meta then
			[](#L-423)			data.metaLinks \= {
				[](#L-424)				link \= info.meta\_link, \-- will be used as [\[\[$link|$text\]\]](https://spaceengineers.wiki.gg/wiki/$link "$link")
				[](#L-425)				url \= info.meta\_url,  \-- will be used as \[$url $text\], only if there is no data.metaLinks.link
				[](#L-426)				text \= info.meta\_text, \--hovertext
			[](#L-427)			}
			[](#L-428)			if not info.meta\_link and not info.meta\_url then
				[](#L-429)				\-- default link target
				[](#L-430)				local title \= mw.title.new(info.template or mw.getCurrentFrame():getParent():getTitle(), 'Template')
				[](#L-431)				if not title then
					[](#L-432)					error('Invalid title ' .. info.template)
				[](#L-433)				end
				[](#L-434)				data.metaLinks.link \= title.fullText
			[](#L-435)			end
			[](#L-436)			if not info.meta\_text then
				[](#L-437)				local msg \= mw.message.new(config.editlink\_hover\_message\_key)
				[](#L-438)				data.metaLinks.text \= msg:exists() and msg:plain() or 'View or edit this template'
			[](#L-439)			end
		[](#L-440)		end
	[](#L-441)	end
	
[](#L-442)	[](#L-443)	\-- above/below
	[](#L-444)	if info.above then
		[](#L-445)		data.above \= {
			[](#L-446)			content \= info.above,
			[](#L-447)			class\= h.mergeAttrs(info.above\_class, config.default\_above\_class),
			[](#L-448)			style \= info.above\_style,
		[](#L-449)		}
	[](#L-450)	end
[](#L-451)	[](#L-452)	if info.below then
		[](#L-453)		data.below \= {
			[](#L-454)			content \= info.below,
			[](#L-455)			class\= h.mergeAttrs(info.below\_class, config.default\_below\_class),
			[](#L-456)			style \= info.below\_style,
		[](#L-457)		}
	[](#L-458)	end
	
[](#L-459)	[](#L-460)	return data
[](#L-461)end
[](#L-462)[](#L-463)\-- parse arguments, convert them into a tree based on their index
[](#L-464)\-- each node on tree is { info = { #data for this node# }, children = {#children nodes#}  }
[](#L-465)function h.buildTree(args, defaults)
	[](#L-466)	local tree \= { info \= {} }
	[](#L-467)	local check \= function(key, value)
		[](#L-468)		local index, name \= string.match(key, '^(\[%d%.\]+):(.+)$')
[](#L-469)		[](#L-470)		\-- no number index found, for root node
		[](#L-471)		if not index then 
			[](#L-472)			tree.info\[key\] \= value
			[](#L-473)			return
		[](#L-474)		end
[](#L-475)		[](#L-476)		\-- filter invalid number index
		[](#L-477)		if string.match(index, '^%.') or string.match(index, '%.$') or string.match(index, '%.%.') then
			[](#L-478)			return
		[](#L-479)		end
		
[](#L-480)		[](#L-481)		\-- find the node that matches the index in the tree
		[](#L-482)		local arr \= h.explode('.', index)
		[](#L-483)		local node \= tree
		[](#L-484)		for \_, v in ipairs(arr) do
			[](#L-485)			v \= tonumber(v)
			[](#L-486)			if not node.children then
				[](#L-487)				node.children \= {}
			[](#L-488)			end
			[](#L-489)			if not node.children\[v\] then 
				[](#L-490)				node.children\[v\] \= { info \= {} }
			[](#L-491)			end
			[](#L-492)			node \= node.children\[v\]
		[](#L-493)		end
		
[](#L-494)		[](#L-495)		node.info\[name\] \= value
	[](#L-496)	end
	[](#L-497)	for k,v in pairs(args) do
		[](#L-498)		check(k, v)
	[](#L-499)	end
	[](#L-500)	return tree
[](#L-501)end
[](#L-502)[](#L-503)function h.render(data)
	[](#L-504)	\-- handle {{[navbox](https://spaceengineers.wiki.gg/wiki/Template:Navbox "Template:Navbox")|child|...}} syntax
	[](#L-505)	if data.CHILD\_MODE then
		[](#L-506)		return NAVBOX\_CHILD\_INDICATOR..mw.text.jsonEncode(data.sections)
	[](#L-507)	end
[](#L-508)	[](#L-509)	\-----  normal case -----
	
[](#L-510)	[](#L-511)	local out \= mw.html.create()
	
[](#L-512)	[](#L-513)	\-- build navbox container
	[](#L-514)	local navbox \= out:tag('div')
		[](#L-515)		:attr('role', 'navigation'):attr('aria-label', 'Navbox')
		[](#L-516)		:addClass(CLASS\_PREFIX..'navbox')
		[](#L-517)		:addClass(data.class)
		[](#L-518)		:addClass(data.striped)
		[](#L-519)		:addClass(data.state)
		[](#L-520)		:cssText(data.style)
[](#L-521)	[](#L-522)	\--title bar
	[](#L-523)	if data.title then
		[](#L-524)		local titlebar \= navbox:tag('div'):addClass(CLASS\_PREFIX..'title')
		[](#L-525)		titlebar:tag('div'):addClass('mw-collapsible-toggle-placeholder')
		[](#L-526)		if data.metaLinks then
			[](#L-527)			titlebar:node(h.renderMetaLinks(data.metaLinks))
		[](#L-528)		end
		[](#L-529)		if data.title then
			[](#L-530)			titlebar:addClass(data.title.class):tag('div')
			[](#L-531)			:addClass(CLASS\_PREFIX..'title-text')