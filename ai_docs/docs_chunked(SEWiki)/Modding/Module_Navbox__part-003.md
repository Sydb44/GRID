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
			[](#L-532)			:addClass(data.title.class)
			[](#L-533)			:cssText(data.title.style)
			[](#L-534)			:wikitext(data.title.content)
		[](#L-535)		end
	[](#L-536)	end
[](#L-537)	[](#L-538)	\--above
	[](#L-539)	if data.above then
		[](#L-540)		navbox:tag('div')
		[](#L-541)		:addClass(CLASS\_PREFIX..'above mw-collapsible-content')
		[](#L-542)		:addClass(data.above.class)
		[](#L-543)		:cssText(data.above.style)
		[](#L-544)		:wikitext(data.above.content)
		[](#L-545)		:attr('id', (not data.title) and mw.uri.anchorEncode(data.above.content) or nil) \-- id for aria-labelledby attribute, if no title
	[](#L-546)	end
	
[](#L-547)	[](#L-548)	\-- sections
	[](#L-549)	if data.sections then
		[](#L-550)		h.renderSections(data.sections, navbox, 0, true)
	[](#L-551)	else
		[](#L-552)		\-- Insert a blank section for completely empty navbox to ensure it behaves correctly when collapsed.
		[](#L-553)		if not data.above and not data.below then 
			[](#L-554)			navbox:tag('div'):addClass(CLASS\_PREFIX..'section mw-collapsible-content')
		[](#L-555)		end
	[](#L-556)	end
[](#L-557)	[](#L-558)	\--below
	[](#L-559)	if data.below then
		[](#L-560)		navbox:tag('div')
		[](#L-561)		:addClass(CLASS\_PREFIX..'below mw-collapsible-content')
		[](#L-562)		:addClass(data.below.class)
		[](#L-563)		:cssText(data.below.style)
		[](#L-564)		:wikitext(data.below.content)
	[](#L-565)	end
	[](#L-566)	return tostring(out)..'\[\[Category:Pages with navboxes\]\]' \-- suggest to use HIDDENCAT here; will be used for maintenance & gadget imports
[](#L-567)end
[](#L-568)[](#L-569)function h.renderSections(data, container, level, even)
	[](#L-570)	for i,sect in ipairs(data) do
		[](#L-571)		\--section box
		[](#L-572)		local section \= container:tag('div')
			[](#L-573)			:addClass(CLASS\_PREFIX..'section mw-collapsible-content')
			[](#L-574)			:addClass(sect.class)
			[](#L-575)			:addClass(sect.state)
			[](#L-576)			:cssText(sect.style)
		[](#L-577)		\-- section header
		[](#L-578)		if sect.header then
			[](#L-579)			section:tag('div')
			[](#L-580)			:addClass(CLASS\_PREFIX..'header')
			[](#L-581)			:addClass(sect.header.class)
			[](#L-582)			:cssText(sect.header.style)
			[](#L-583)			:tag('div'):addClass('mw-collapsible-toggle-placeholder'):done()
			[](#L-584)			:tag('div'):addClass(CLASS\_PREFIX..'header-text'):wikitext(sect.header.content)
		[](#L-585)		end
		[](#L-586)		\-- above:
		[](#L-587)		if sect.above then
			[](#L-588)			section:tag('div')
			[](#L-589)			:addClass(CLASS\_PREFIX..'above mw-collapsible-content')
			[](#L-590)			:addClass(sect.above.class)
			[](#L-591)			:cssText(sect.above.style)
			[](#L-592)			:wikitext(sect.above.content)
		[](#L-593)		end
		[](#L-594)		\-- body: groups&lists
		[](#L-595)		local box \= section:tag('div'):addClass(CLASS\_PREFIX..'section-body mw-collapsible-content')
		[](#L-596)		even \= h.renderBody(sect.body, box, level, (level\==0) and true or even) \-- reset even status each section
		[](#L-597)		\-- below:
		[](#L-598)		if sect.below then
			[](#L-599)			section:tag('div')
			[](#L-600)			:addClass(CLASS\_PREFIX..'below mw-collapsible-content')
			[](#L-601)			:addClass(sect.below.class)
			[](#L-602)			:cssText(sect.below.style)
			[](#L-603)			:wikitext(sect.below.content)
		[](#L-604)		end
	[](#L-605)	end
	[](#L-606)	return even
[](#L-607)end
[](#L-608)
[](#L-609)[](#L-610)function h.renderMetaLinks(info)
	[](#L-611)	local box \= mw.html.create('span'):addClass(CLASS\_PREFIX..'meta')
	[](#L-612)	local meta \= box:tag('span'):addClass('nv nv-view')
	
[](#L-613)	[](#L-614)	if info.link then 
		[](#L-615)		meta:wikitext('\[\['..info.link..'|')
			[](#L-616)			:tag('span'):wikitext(info.text):attr('title', info.text):done()
			[](#L-617)			:wikitext('\]\]')
	[](#L-618)	elseif info.url then
		[](#L-619)		meta:wikitext('\['..info.url..' ')
			[](#L-620)			:tag('span'):wikitext(info.text):attr('title', info.text):done()
			[](#L-621)			:wikitext('\]')
	[](#L-622)	end
	
[](#L-623)	[](#L-624)	return box
[](#L-625)end
[](#L-626)[](#L-627)function h.renderBody(info, box, level, even)
	[](#L-628)	local count \= 0
	[](#L-629)	for \_,v in h.orderedPairs(info) do
		[](#L-630)		if v.group or v.list or v.sections then
			[](#L-631)			count \= count + 1
			[](#L-632)			\-- row container
			[](#L-633)			local row \= box:tag('div'):addClass(CLASS\_PREFIX..'row')
			[](#L-634)			\-- group cell
			[](#L-635)			if v.group or (v.sections and level \> 0 and not v.list) then
				[](#L-636)				local groupCell \= row:tag('div')
					[](#L-637)					:addClass(CLASS\_PREFIX..'group level-'..level)
					[](#L-638)					:addClass((level \> 0) and CLASS\_PREFIX..'subgroup' or nil)
				[](#L-639)				local groupContentWrap \= groupCell:tag('div'):addClass(CLASS\_PREFIX..'wrap')
				[](#L-640)				if v.group then
					[](#L-641)					groupCell:addClass(v.group.class):cssText(v.group.style)
					[](#L-642)					groupContentWrap:wikitext(v.group.content)
				[](#L-643)				else
					[](#L-644)					groupCell:addClass('empty')
					[](#L-645)					row:addClass('empty-group-list')
				[](#L-646)				end
			[](#L-647)			else
				[](#L-648)				row:addClass('empty-group')
			[](#L-649)			end
			[](#L-650)			\-- list cell
			[](#L-651)			local listCell \= row:tag('div'):addClass(CLASS\_PREFIX..'listbox')
			[](#L-652)			if not v.list and not v.sections then
				[](#L-653)				listCell:addClass('empty')
				[](#L-654)				row:addClass('empty-list')
			[](#L-655)			end
			[](#L-656)			if v.list or (v.group and not v.sections) then
				[](#L-657)				\--listCell:node(h.renderList(v\['list'\] or '', k, level, args))
				[](#L-658)				even \= not even \-- flip even/odd status
				[](#L-659)				local cell \= listCell:tag('div')
				[](#L-660)				:addClass(CLASS\_PREFIX..'wrap')
				[](#L-661)				:addClass(even and CLASS\_PREFIX..'even' or CLASS\_PREFIX..'odd')
				[](#L-662)				if v.list then
					[](#L-663)					cell:addClass(v.list.class):cssText(v.list.style)
					[](#L-664)					:tag('div'):addClass(CLASS\_PREFIX..'list'):wikitext(v.list.content)
				[](#L-665)				end
			[](#L-666)			end
			[](#L-667)			if v.sections then
				[](#L-668)				local sublistBox \= listCell:tag('div'):addClass(CLASS\_PREFIX..'sublist level-'..level)
				[](#L-669)				even \= h.renderSections(v.sections, sublistBox, level+1, even)
			[](#L-670)			end
		[](#L-671)		end
	[](#L-672)	end
	[](#L-673)	if count \> 0 then
		[](#L-674)		box:css('--count', count) \-- for flex-grow
	[](#L-675)	end
	[](#L-676)	return even
[](#L-677)end
[](#L-678)[](#L-679)\-- pairs, but sort the keys alphabetically
[](#L-680)function h.orderedPairs(t, f)
	[](#L-681)	local a \= {}
	[](#L-682)	for n in pairs(t) do table.insert(a, n) end
	[](#L-683)	table.sort(a, f)
	[](#L-684)	local i \= 0      \-- iterator variable
	[](#L-685)	local iter \= function ()   \-- iterator function
		[](#L-686)		i \= i + 1
		[](#L-687)		if a\[i\] \== nil then return nil
		[](#L-688)		else return a\[i\], t\[a\[i\]\]
		[](#L-689)		end
	[](#L-690)	end
	[](#L-691)	return iter
[](#L-692)end
[](#L-693)[](#L-694)\-- For cascading parameters, such as style or class, they are merged in exact order (from general to specific). 
[](#L-695)\-- Any parameter starting with multiple hyphens(minus signs) will terminate the cascade.
[](#L-696)\-- An example:
[](#L-697)\-- For group\_1.1, its style is affected by parameters |group\_1.1\_style=... , |subgroup\_level\_1\_style=... , and |subgroup\_style=... .
[](#L-698)\-- If we have |group\_1.1\_style= color:red; |subgroup\_level\_1\_style= font-weight: bold; and |subgroup\_style= color: green; ,
[](#L-699)\-- the style of group\_1.1 will be style="color:green; font-weight: bold; color: red;" ;
[](#L-700)\-- if we have |group\_1.1\_style= -- color:red; |subgroup\_level\_1\_style= font-weight: bold; and |subgroup\_style= color: green; ,
[](#L-701)\-- the style of group\_1.1 will be style="color: red;" only, and the cascade is no longer performed for |subgroup\_level\_1\_style and |subgroup\_style.
[](#L-702)function h.mergeAttrs(...)
	[](#L-703)	local trim \= mw.text.trim
	[](#L-704)	local s \= ''
	[](#L-705)	for i\=1, select('#', ...) do
		[](#L-706)		local v \= trim(select(i, ...) or '')
		[](#L-707)		local str \= string.match(v, '^%-%-+(.\*)$')
		[](#L-708)		if str then
			[](#L-709)			s \= trim(str..' '..s)
			[](#L-710)			break
		[](#L-711)		else
			[](#L-712)			s \= trim(v..' '..s)
		[](#L-713)		end
	[](#L-714)	end
	[](#L-715)	if s \== '' then s \= nil end
	[](#L-716)	return s
[](#L-717)end
[](#L-718)[](#L-719)function h.runHook(key, ...)
	[](#L-720)	if hooks\[key\] then
		[](#L-721)		hooks\[key\](...)
	[](#L-722)	end
[](#L-723)end
[](#L-724)[](#L-725)\-----------------------------------------------
[](#L-726)return p