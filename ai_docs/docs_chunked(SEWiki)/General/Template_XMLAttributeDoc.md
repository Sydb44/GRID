---
title: "Template:XMLAttributeDoc"
url: "https://spaceengineers.wiki.gg/wiki/Template:XMLAttributeDoc"
category: "General"
wiki_page: "Template:XMLAttributeDoc"
includes_blocks: true
---

# Template:XMLAttributeDoc - Official Space Engineers Wiki

## Navigation menu

### Search

(#searchInput)

  
Usage example:

\_\_TOC\_\_

{{XMLDocWrapper|start}}

{{#vardefine:XMLDocAddTOC|true}}<!-- enable TOC linking for all attribute docs following it -->

{{XMLAttributeDoc|attribute=SomeAttrib1|type=Whoknows|default=Probablynull|content=This does things}}
{{XMLAttributeDoc|attribute=SomeAttrib2|type=Whoknows|default=Probablynull|content=This does things|added=1.206}}

{{#vardefine:XMLDocAddTOC|false}}<!-- disable it back again (used for obsolete) -->

{{XMLAttributeDoc|attribute=SomeAttrib3|type=Whoknows|default=Probablynull|content=This does things}}

{{XMLDocWrapper|end}}

|     |     |     |
| --- | --- | --- |
| **[SomeAttrib1](#SomeAttrib1)** (attribute[\[1\]](#cite_note-xmlattribute-1)) | [Type](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Data_Types "Modding/Reference/Data Types"): Whoknows | [Default](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC#Advanced-Defaults "Modding/Reference/SBC"): **`Probablynull`** |
| This does things |     |     |
| **[SomeAttrib2](#SomeAttrib2)** (attribute[\[1\]](#cite_note-xmlattribute-1)) | [Type](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Data_Types "Modding/Reference/Data Types"): Whoknows | [Default](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC#Advanced-Defaults "Modding/Reference/SBC"): **`Probablynull`** |
| This does things<br><br>(Added in [SE v1.206](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Patch_Changes/1.206 "Modding/Reference/Patch Changes/1.206")) |     |     |
| **[SomeAttrib3](#SomeAttrib3)** (attribute[\[1\]](#cite_note-xmlattribute-1)) | [Type](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Data_Types "Modding/Reference/Data Types"): Whoknows | [Default](https://spaceengineers.wiki.gg/wiki/Modding/Reference/SBC#Advanced-Defaults "Modding/Reference/SBC"): **`Probablynull`** |
| This does things |     |     |

* * *

Relies on [Template:XMLDocWrapper](https://spaceengineers.wiki.gg/wiki/Template:XMLDocWrapper "Template:XMLDocWrapper") before and after all of the entries as seen in the source of this page.

Use the [Template:XMLElementDoc](https://spaceengineers.wiki.gg/wiki/Template:XMLElementDoc "Template:XMLElementDoc") for tags.

Flexible format for documenting an XML attribute

|     |     |     |     |     |
| --- | --- | --- | --- | --- |
Template parameters\[[Edit template data](https://spaceengineers.wiki.gg/wiki/Template:XMLAttributeDoc?action=edit&templatedata=edit "Template:XMLAttributeDoc")\]
This template prefers block formatting of parameters.
| Parameter |     | Description | Type | Status |
| --- | --- | --- | --- | --- |
| attribute | `attribute` | The attribute name itself | String | required |
| type | `type` `valuetype` | The data type of this attribute which determines what the user can write. See some examples at /Modding/Reference/Data\_Types page. | String | required |
| default | `default` `defaultvalue` | The value of this attribute when not present in the file. | String | required |
| content | `content` | The documentation for this attribute, can be blank but if leaving blank please add the MissingDocs category to the page and remind people in a comment to remove that category. | Content | suggested |
| link | `link` | Optional in-page-link override that's used on the attribute name. | String | optional |
| added | `added` | SE version when this element was added. Must match a subpage name from /Modding/Reference/Patch\_Changes/(here)<br><br>Example<br><br>1.206 | String | suggested |

1.  ↑ [Jump up to: 1.0](#cite_ref-xmlattribute_1-0) [1.1](#cite_ref-xmlattribute_1-1) [1.2](#cite_ref-xmlattribute_1-2) [What are XML attributes?](https://www.w3schools.com/xml/xml_attributes.asp)