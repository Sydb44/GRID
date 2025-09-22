---
title: "Template:XMLElementDoc"
url: "https://spaceengineers.wiki.gg/wiki/Template:XMLElementDoc"
category: "General"
wiki_page: "Template:XMLElementDoc"
includes_blocks: true
---

# Template:XMLElementDoc - Official Space Engineers Wiki

## Navigation menu

### Search

(#searchInput)

  
Usage example:

\_\_TOC\_\_

{{XMLDocWrapper|start}}

{{#vardefine:XMLDocAddTOC|true}}<!-- advanced: enable TOC linking for all element docs following it -->

{{XMLElementDoc|tag=TagA|type=Whoknows|default=probablynull|content=This does something}}

{{XMLElementDoc|added=1.206|tag=TagB|type=Whoknows|default=probablynull|content=
This does something
{{XMLDocWrapper|start}}
{{XMLElementDoc|tag=Deeper|type=Whoknows|link=TagB.Deeper|default=yep|content=Nah}}
{{XMLDocWrapper|end}}
}}

{{#vardefine:XMLDocAddTOC|false}}<!-- advanced: disable it back again (used for obsolete tags) -->

{{XMLElementDoc|tag=TagC|type=Whoknows|default=probablynull|content=This does something}}
{{XMLDocWrapper|end}}

Result:

* * *

Relies on [Template:XMLDocWrapper](https://spaceengineers.wiki.gg/wiki/Template:XMLDocWrapper "Template:XMLDocWrapper") before and after all of the entries as seen in the source of this page.

Use the [Template:XMLAttributeDoc](https://spaceengineers.wiki.gg/wiki/Template:XMLAttributeDoc "Template:XMLAttributeDoc") for attributes.

Flexible format for documenting an XML element

|     |     |     |     |     |
| --- | --- | --- | --- | --- |
Template parameters\[[Edit template data](https://spaceengineers.wiki.gg/wiki/Template:XMLElementDoc?action=edit&templatedata=edit "Template:XMLElementDoc")\]
This template prefers block formatting of parameters.
| Parameter |     | Description | Type | Status |
| --- | --- | --- | --- | --- |
| tag | `tag` `node` `element` | The element name itself | String | required |
| type | `type` `valuetype` | The data type of this element which determines what the user can write. See some examples at /Modding/Reference/Data\_Types page. | String | required |
| default | `default` `defaultvalue` | The value of this element when not present in the file. | String | required |
| content | `content` | The documentation for this element, can be blank but if leaving blank please add the MissingDocs category to the page and remind people in a comment to remove that category. | Content | suggested |
| link | `link` | Optional in-page-link override that's used on the element name. | String | optional |
| added | `added` | SE version when this element was added. Must match a subpage name from /Modding/Reference/Patch\_Changes/(here)<br><br>Example<br><br>1.206 | String | suggested |