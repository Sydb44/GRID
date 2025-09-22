---
title: "Module:Navbox"
url: "https://spaceengineers.wiki.gg/wiki/Module:Navbox"
category: "Modding"
wiki_page: "Module:Navbox"
includes_blocks: true
---

# Module:Navbox - Official Space Engineers Wiki

[](#L-1)\-- version 1.2.5
[](#L-2)[](#L-3)\-- config table for RANGER.
[](#L-4)\-- If you want to change the default config, DO NOT change it here,
[](#L-5)\-- please do it via the \`onLoadConfig\` hook in [\[\[Module:Navbox/Hooks\]\]](https://spaceengineers.wiki.gg/wiki/Module:Navbox/Hooks "Module:Navbox/Hooks").
[](#L-6)local config \= {
	[](#L-7)	default\_navbox\_class \= "navigation-not-searchable",   \-- Base value of the \`class\` parameter.
	[](#L-8)	default\_title\_class \= nil,    \-- Base value of the \`title\_class\` parameter.
	[](#L-9)	default\_above\_class \= nil,    \-- Base value of the \`above\_class\` parameter.
	[](#L-10)	default\_below\_class \= nil,    \-- Base value of the \`below\_class\` parameter.
	[](#L-11)	default\_section\_class \=nil,   \-- Base value of the \`section\_class\` parameter.
	[](#L-12)	default\_header\_class \= nil,   \-- Base value of the \`header\_class\` parameter.
	[](#L-13)	default\_group\_class \= nil,    \-- Base value of the \`group\_class\` parameter.
	[](#L-14)	default\_list\_class \= 'hlist', \-- Base value of the \`list\_class\` parameter.
	
[](#L-15)	[](#L-16)	default\_header\_state \= nil, \-- Base value of the \`state\` parameter.
[](#L-17)	[](#L-18)	editlink\_hover\_message\_key \= 'Navbox-edit-hover', \-- The system message name for hover text of the edit icon. 
[](#L-19)	[](#L-20)	auto\_flatten\_top\_level \= false, \-- If true, when a section has only one list with no content and no corresponding group but has sublists, these sublists will be moved to top level.
	[](#L-21)	\-- This helps make the hierarchy of sections and content clearer.
	[](#L-22)	\-- An example:
	[](#L-23)	\-- {{navbox
	[](#L-24)	\-- ...
	[](#L-25)	\--   |header1 = Items
	[](#L-26)	\--   | group1.1 = Weapons
	[](#L-27)	\--   |  list1.1 = Swords · Guns · Wands
	[](#L-28)	\--   | group1.2 = Armors
	[](#L-29)	\--   |  list1.2 = Head pieces · Capes
	[](#L-30)	\--   |header2 = NPCs
	[](#L-31)	\--   | group2.1 = Town NPCs
	[](#L-32)	\--   |  list2.1 = Guide · Witch
	[](#L-33)	\-- ...
	[](#L-34)	\-- }}
	[](#L-35)	\-- will be equal to:
	[](#L-36)	\-- {{navbox
	[](#L-37)	\-- ...
	[](#L-38)	\--   |header1 = Items
	[](#L-39)	\--   | group2 = Weapons
	[](#L-40)	\--   |  list2 = Swords · Guns · Wands
	[](#L-41)	\--   | group3 = Armors
	[](#L-42)	\--   |  list3 = Head pieces · Capes
	[](#L-43)	\--   |header5 = NPCs
	[](#L-44)	\--   | group6 = Town NPCs
	[](#L-45)	\--   |  list6 = Guide · Witch
	[](#L-46)	\-- ...
	[](#L-47)	\-- }}
	
[](#L-48)	[](#L-49)	custom\_render\_handle \= nil, \-- usually for debugging purposes only. if set, it should be a function accept 2 parameters: \`dataTree\` and \`args\`, and return a string as module output.
[](#L-50)}
[](#L-51)[](#L-52)\---------------------------------------------------------------------
[](#L-53)[](#L-54)\-- Argument alias.
[](#L-55)local CANONICAL\_NAMES \= {
	[](#L-56)	\['titlestyle'\] \= 'title\_style',
	[](#L-57)	\['listclass'\] \= 'list\_class',
	[](#L-58)	\['groupstyle'\] \= 'group\_style',
	[](#L-59)	\['collapsible'\] \= 'state',
	[](#L-60)	\['editlink'\] \= 'meta',
	[](#L-61)	\['editlinks'\] \= 'meta',
	[](#L-62)	\['editicon'\] \= 'meta',
	[](#L-63)	\['edit\_link'\] \= 'meta',
	[](#L-64)	\['edit\_links'\] \= 'meta',
	[](#L-65)	\['edit\_icon'\] \= 'meta',
	[](#L-66)	\['navbar'\] \= 'meta',
	[](#L-67)	\['name'\] \= 'template',
	[](#L-68)	\['evenodd'\] \= 'striped',
	[](#L-69)	\['class'\] \= 'navbox\_class',
	[](#L-70)	\['css'\] \= 'navbox\_style',
	[](#L-71)	\['style'\] \= 'navbox\_style',
	[](#L-72)	\['group'\] \= '1:group',
	[](#L-73)	\['list'\] \= '1:list',
[](#L-74)}
[](#L-75)[](#L-76)local DEFAULT\_ARGS \= {
	[](#L-77)	\['meta'\] \= true,
[](#L-78)}
[](#L-79)[](#L-80)local STATES \= {
	[](#L-81)	\['no'\] \= '',
	[](#L-82)	\['off'\] \= '',
	[](#L-83)	\['plain'\] \= '',
	[](#L-84)	\['collapsed'\] \= 'mw-collapsible mw-collapsed',
	[](#L-85)	\['expanded'\] \= 'mw-collapsible',
[](#L-86)}
[](#L-87)[](#L-88)local BOOL\_FALSE \= {
	[](#L-89)	\['no'\] \= true,
	[](#L-90)	\['off'\] \= true,
	[](#L-91)	\['false'\] \= true,
[](#L-92)}
[](#L-93)[](#L-94)local STRIPED \= {
	[](#L-95)	\['odd'\] \= 'striped-odd',
	[](#L-96)	\['swap'\] \= 'striped-odd',
	[](#L-97)	\['y'\] \= 'striped-even',
	[](#L-98)	\['yes'\] \= 'striped-even',
	[](#L-99)	\['on'\] \= 'striped-even',
	[](#L-100)	\['even'\] \= 'striped-even',
	[](#L-101)	\['striped'\] \= 'striped-even',
[](#L-102)}
[](#L-103)[](#L-104)local NAVBOX\_CHILD\_INDICATOR \= '!!C$H$I$L$D!!'
[](#L-105)local NAVBOX\_CHILD\_INDICATOR\_LENGTH \= string.len( NAVBOX\_CHILD\_INDICATOR )
[](#L-106)[](#L-107)local CLASS\_PREFIX \= 'ranger-'
[](#L-108)[](#L-109)\---------------------------------------------------------------------
[](#L-110)[](#L-111)local p \= {}
[](#L-112)local h \= {} \-- non-public
[](#L-113)local hooks \= mw.title.new('[Module:Navbox/Hooks](https://spaceengineers.wiki.gg/wiki/Module:Navbox/Hooks)').exists and require('[Module:Navbox/Hooks](https://spaceengineers.wiki.gg/wiki/Module:Navbox/Hooks)') or {}
[](#L-114)[](#L-115)\---------------------------------------------------------------------
[](#L-116)[](#L-117)\-- For templates: {{#invoke:navbox|main|...}}
[](#L-118)function p.main(frame)
	[](#L-119)	local args \= p.mergeArgs(frame)
	[](#L-120)	return p.build(args, true)
[](#L-121)end
[](#L-122)[](#L-123)\-- For modules: return require('module:navbox').build(args)
[](#L-124)\-- By default this method will skip the arguments sanitizing phase 
[](#L-125)\-- (and onSanitizeArgsStart/onSanitizeArgsEnd hooks).
[](#L-126)\-- Set \`doParseArgs\` to true to do arguments sanitizing.
[](#L-127)\-- If \`customConfig\` table is provided, it will be merged into default config table (after onLoadConfig()).
[](#L-128)\-- If \`customHooks\` table is provided, all default hook handles will be overrided, unprovided hooks will be empty.
[](#L-129)function p.build(args, doParseArgs, customConfig, customHooks)
	[](#L-130)	if customHooks then
		[](#L-131)		hooks \= customHooks
	[](#L-132)	end
	
[](#L-133)	[](#L-134)	if doParseArgs then 
		[](#L-135)		args \= h.parseArgs(args)
	[](#L-136)	end
[](#L-137)	[](#L-138)	h.runHook('onLoadConfig', config, args)
[](#L-139)	[](#L-140)	if customConfig then
		[](#L-141)		for k,v in pairs(customConfig) do
			[](#L-142)			config\[k\] \= v
		[](#L-143)		end
	[](#L-144)	end
	
[](#L-145)	[](#L-146)	\--merge default args
	[](#L-147)	for k,v in pairs(DEFAULT\_ARGS) do
		[](#L-148)		if args\[k\] \== nil then
			[](#L-149)			args\[k\] \= DEFAULT\_ARGS\[k\]
		[](#L-150)		end
	[](#L-151)	end
[](#L-152)	[](#L-153)	h.runHook('onBuildTreeStart', args)
	[](#L-154)	local dataTree \= h.buildDataTree(args)
	[](#L-155)	h.runHook('onBuildTreeEnd', dataTree, args)
	
[](#L-156)	[](#L-157)	if type(config.custom\_render\_handle) \== 'function' then
		[](#L-158)		return config.custom\_render\_handle(dataTree, args)
	[](#L-159)	else
		[](#L-160)		return h.render(dataTree)
	[](#L-161)	end
[](#L-162)end
[](#L-163)[](#L-164)\-- merge args from frame and frame:getParent()
[](#L-165)\-- It may be used when creating custom wrapping navbox module.
[](#L-166)\--
[](#L-167)\-- For example, Module:PillNavbox
[](#L-168)\--
[](#L-169)\-- local RANGER = require('Module:Navbox')
[](#L-170)\-- local p = {}
[](#L-171)\-- function p.main(frame)
[](#L-172)\--     return RANGER.build(RANGER.mergeArgs(frame), true, {
[](#L-173)\--         default\_navbox\_class = 'pill', -- use "pill" style by default.
[](#L-174)\--     })
[](#L-175)\-- end
[](#L-176)\-- return p
[](#L-177)\--
[](#L-178)function p.mergeArgs(frame)
	[](#L-179)	local inputArgs \= {}
	
[](#L-180)	[](#L-181)	for k, v in pairs(frame.args) do
		[](#L-182)		v \= mw.text.trim(tostring(v))
		[](#L-183)		if v ~= '' then
			[](#L-184)			inputArgs\[k\] \= v
		[](#L-185)		end
	[](#L-186)	end
	
[](#L-187)	[](#L-188)	for k, v in pairs(frame:getParent().args) do
		[](#L-189)		v \= mw.text.trim(v)
		[](#L-190)		if v ~= '' then
			[](#L-191)			inputArgs\[k\] \= v
		[](#L-192)		end
	[](#L-193)	end
	
[](#L-194)	[](#L-195)	return inputArgs
[](#L-196)end
[](#L-197)[](#L-198)\------------------------------------------------------------------------
[](#L-199)[](#L-200)\-- equivalent to mw.text.split(str, div, true) for non-empty separator, but can be over 60x faster, since the latter is Unicode-aware.
[](#L-201)\-- Original version credit: [http://richard.warburton.it](http://richard.warburton.it/).
[](#L-202)function h.explode(div, str)
	[](#L-203)	if (div\=='') then return nil end
	[](#L-204)	local pos,arr \= 0,{}
	[](#L-205)	\-- for each divider found
	[](#L-206)	for st,sp in function() return string.find(str,div,pos,true) end do
		[](#L-207)		arr\[#arr+1\] \= string.sub(str,pos,st\-1) \-- Attach chars left of current divider
		[](#L-208)		pos \= sp+1 \-- Jump past current divider
	[](#L-209)	end
	[](#L-210)	arr\[#arr+1\] \= string.sub(str,pos) \-- Attach chars right of last divider
	[](#L-211)	return arr
[](#L-212)end
[](#L-213)[](#L-214)function h.parseArgs(inputArgs)
	[](#L-215)	h.runHook('onSanitizeArgsStart', inputArgs)
	
[](#L-216)	[](#L-217)	local args \= {}
	
[](#L-218)	[](#L-219)	for k, v in pairs(inputArgs) do
		[](#L-220)		if type(k) \== 'string' then
			[](#L-221)			\-- all named args have already been trimmed
			[](#L-222)			local key \= h.normalizeKey(k)
			[](#L-223)			args\[key\] \= h.normalizeValue(key, v)
		[](#L-224)		else
			[](#L-225)			args\[k\] \= mw.text.trim(v) \-- keep number-index arguments (for {{[navbox](https://spaceengineers.wiki.gg/wiki/Template:Navbox "Template:Navbox")|child|...}})
		[](#L-226)		end
	[](#L-227)	end
	
[](#L-228)	[](#L-229)	h.runHook('onSanitizeArgsEnd', args, inputArgs)
	
[](#L-230)	[](#L-231)	return args
[](#L-232)end
[](#L-233)[](#L-234)\-- Normalize the name string of arguments.
[](#L-235)\-- the normalized form is (index:)?name, in which:
[](#L-236)\-- index is number index such as 1, 1.3, 1.2.45,
[](#L-237)\-- name is in lowercase underscore-case, such as group, group\_style
[](#L-238)\-- e.g: header\_state, 1.3:list\_style
[](#L-239)\-- the input argument name can be:
[](#L-240)\-- \* camel-case: listStyle, ListStyle
[](#L-241)\-- \* space separated: list style
[](#L-242)\-- \* prefix+index+postfix?, and can be in camel-case or space/hyphen separated or mixed: list 1 style, list1, list1Style, list1\_style
[](#L-243)\-- \* index.name: 1.3.list
[](#L-244)\-- \* index\_name: 1.3\_list (Space separated are treated as underscore separated, therefore 1.3 list are vaild too)
[](#L-245)function h.normalizeKey(s)
	[](#L-246)	\-- camel-case to lowercase underscore-case
	[](#L-247)	s \= s:gsub('%l%f\[%u\]', '%0\_') \-- listStyle to list\_style
	[](#L-248)	s \= (s:gsub(' ', '\_')):lower() \-- space to underscore 
	[](#L-249)	s \= s:gsub('%l%f\[%d\]', '%0\_') \-- group1\* to group\_1\*
	[](#L-250)	s \= s:gsub('%d%f\[%l\]', '%0\_') \-- \*1style to \*1\_style
	
[](#L-251)	[](#L-252)	\-- number format x\_y\_z to x.y.z
	[](#L-253)	s \= s:gsub('(%d)\_%f\[%d\]', '%1%.')
	
[](#L-254)	[](#L-255)	\-- move index to the beginning:
	[](#L-256)	\-- group\_1.2\_style to 1.2:group\_style
	[](#L-257)	\-- group\_1 to 1:group
	[](#L-258)	s \= s:gsub('^(\[%l\_\]+)\_(\[%d%.\]+)', '%2:%1')
	
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