---
title: "Template:Navbox"
url: "https://spaceengineers.wiki.gg/wiki/Template:Navbox"
category: "General"
wiki_page: "Template:Navbox"
---

# Template:Navbox - Official Space Engineers Wiki

## Navigation menu

### Search

(#searchInput)

![](https://commons.wiki.gg/images/Warning-red.svg?a46ec6)

Don't call this template directly from any content page!

This template is intended to be used inside of another template. Then that template in turn may be used on content pages.

This template is designed to set up navigational templates relatively quickly with one or more lists of links. We highly recommend using this template for standardizing navigational templates and ease of use, especially for mobile devices.

See [the support wiki](https://support.wiki.gg/wiki/RANGER_navboxes "support:RANGER navboxes") for more information, including installation steps and further examples.

## Basic example

The following example demonstrates the core functionality of this template: the title text, one standard link group, and one link group that contains two sub-groups. The rows are striped for easier readability.

{{Navbox
| template \= <template\_title> <!-- Required. e.g. \`|template=Items\` for template:Items -->

| title \= Items
| striped \= even

| group1 \= Consumables
| list1 \=
\* Health Potion
\* Mana Potion

| group2 \= Weapons

| group2.1 \= Swords
| list2.1 \=
\* Wooden Sword
\* Rusted Sword
\* Steel Sword

| group2.2 \= Bows
| list2.2 \=
\* Shortbow
\* Crossbow
\* Longbow
}}

## Parameters

### Main

The following parameters modify the navbox as a whole.

| Parameter | Description |
| --- | --- |
| `template`  <br>`name` | (**Required**) Title of the template that the edit icon links to. e.g. `Items` for template:Items. |
| `title` | Text that appears at the top of the navbox. |
| `state`  <br>`collapsible` | Controls if a navbox should be expanded or collapsed when the page loads. This only affects the whole navbox; if [sections](#Sections) are used, they are treated differently.<br><br>*   `expanded` (**default**) - the navbox will start open and readers can collapse it.<br>*   `collapsed` - the navbox will start closed and readers can expand it.<br>*   `off`, `no`, or `plain` - the navbox will start open and cannot be collapsed.<br><br>Advanced users can modify this on a page-by-page basis; see [the support wiki](https://support.wiki.gg/wiki/RANGER_navboxes#Controlling_the_collapsible "support:RANGER navboxes") for more information. |
| `editlinks` | Controls if an edit icon should be displayed at the top-left of the navbox, making it easier for users to interact with the template itself.<br><br>*   unset (**default**) - displays the edit icon<br>*   `off` or `no` - hides the edit icon |
| `above` | Text that appears above all list groups, directly below the title. |
| `below` | Text that appears below all list groups, at the bottom of the navbox. |
| `striped`  <br>`evenodd` | Controls if the navbox rows should have zebra striping on even or odd rows, making it easier for users to distinguish two rows apart from each other. If [sections](#Sections) are used, each section resets the even/odd counter.<br><br>*   unset (**default**) - all rows have the same background<br>*   `y`, `yes`, `on`, `striped`, or `even` - even-numbered rows are highlighted<br>*   `swap` or `odd` - odd-numbered rows are highlighted |

### Sections

The following parameters define sections within the navbox with their own titles.

| Parameter | Description |
| --- | --- |
| `header_n_` | Text that appears at the top of the section, where _n_ is any positive integer. If the value is set to two or more `-` (e.g. `--`, `-----`, etc.) the new section will have no header bar and cannot be collapsed.<br><br>All groups and lists that are _n_ or higher will appear in this section unless there is a higher `header_n_` later in the template. For example, if a navbox defines `header1` and `header4`, the first section will include `list1`, `list2`, and `list3` (and any of their sub-lists), while the second section will include all remaining lists starting at `list4` and their sub-lists. |
| `header_state`  <br>`state_n_` | `header_state` controls if all sections, by default, should be expanded or collapsed when the page loads.<br><br>`state_n_` overrides `header_state` for the specific section defined by `header_n_` (where _n_ is a matching integer).<br><br>*   `expanded` (**default**) - the section will start open and readers can collapse it.<br>*   `collapsed` - the section will start closed and readers can expand it.<br>*   `off` or `plain` - the section will start open and cannot be collapsed.<br><br>Advanced users can modify these on a page-by-page basis; see [the support wiki](https://support.wiki.gg/wiki/RANGER_navboxes#Controlling_the_collapsible "support:RANGER navboxes") for more information.<br><br>Both parameters have no effect on sections with headers set to two or more `-`, which are always expanded and cannot be collapsed. |

### List groups

The following parameters define the list groups.

| Parameter | Description |
| --- | --- |
| `group_n_` | Text label for a list, which appears on the left on desktop or at the top on mobile, where _n_ is any positive integer.<br><br>This parameter is optional; if a `list_n_` does not have a matching `group_n_`, the list will take the full width on desktop. |
| `list_n_` | A wikitext list, where _n_ is any positive integer. |
| `group_n_._x_`  <br>`group_n_._x_._y_`  <br>etc. | Text label for sub-lists that appear under `group_n_`, `group_n_._x_`, etc. |
| `list_n_._x_`  <br>`list_n_._x_._y_`  <br>etc. | Wikitext sub-lists. |

### Styling

The following parameters add inline styling or your custom CSS classes to specific elements of the navbox.

To assist with text alignment, three default classes are available: `align-left`, `align-center`, and `align-right`.

| Parameter | Description |
| --- | --- |
| `navbox_style`  <br>`navbox_class` | Modifies the parent navbox element; `class` can be used as a shorthand for `navbox_class`<br><br>Two default classes are available:<br><br>*   `pill` changes the links to pill-styled rather than dot-separated<br>*   `pill-mobile` only changes the links to pill-styled on mobile devices |
| `title_style`  <br>`title_class` | Modifies the title bar |
| `above_style`  <br>`above_class` | Modifies the `above` text row |
| `below_style`  <br>`below_class` | Modifies the `below` text row |
| `header_style`  <br>`header_class` | Modifies all section headers (_not_ the title bar) |
| `header_n__style`  <br>`header_n__class` | Modifies the specific section header _n_ |
| `section_n__style`  <br>`section_n__class` | Modifies the container holding the section defined by a matching `header_n_` |
| `group_style`  <br>`group_class` | Modifies all base groups (`group_n_`), but _not_ any subgroups (`group_n_._x_`, etc.) |
| `subgroup_style`  <br>`subgroup_class` | Modifies all subgroups at all levels (`group_n_._x_`, `group_n_._x_._y_`, etc.) |
| `group_A__style`  <br>`group_A__class` | Modifies the specific group _A_, where _A_ is any _n_, _n_._x_, _n_._x_._y_, etc. |
| `list_style`  <br>`list_class` | Modifies all lists. Note, in this context, "list" refers to the container of a `list_n_` parameter, not a `ul` or `ol` element inside the parameter |
| `list_A__style`  <br>`list_A__class` | Modifies the specific list _A_, where _A_ is any _n_, _n_._x_, _n_._x_._y_, etc. |