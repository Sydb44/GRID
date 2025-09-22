---
title: "Template:Math table"
url: "https://spaceengineers.wiki.gg/wiki/Template:Math_table"
category: "General"
wiki_page: "Template:Math table"
---

# Template:Math table - Official Space Engineers Wiki

(#searchInput)

## Description

This template is used to display math using TeX. Specifically, it provides a framework to then include elements using [Template:Math formula](https://spaceengineers.wiki.gg/wiki/Template:Math_formula "Template:Math formula"), [Template:Math define](https://spaceengineers.wiki.gg/wiki/Template:Math_define "Template:Math define"), and [Template:Math step](https://spaceengineers.wiki.gg/wiki/Template:Math_step "Template:Math step"). Some combination of the other math templates are required.

## Syntax

This template always takes the following form.

{{Math table
|formulas=
<Math formula templates>
|definitions=
<Math define templates>
|steps=
<Math step templates>
}}

If not using a particular type of sub-template, you may leave that section out.

## Parameters

All parameters to this template are named.

*   align: Horizontal of the table within the page. (Defaults to center)
*   formulas: Elements to include in the formulas section. (Use [Template:Math formula](https://spaceengineers.wiki.gg/wiki/Template:Math_formula "Template:Math formula"))
*   definitions: Elements to include in the definitions section. (Use [Template:Math define](https://spaceengineers.wiki.gg/wiki/Template:Math_define "Template:Math define"))
*   steps: Elements to include in the definitions section. (Use [Template:Math step](https://spaceengineers.wiki.gg/wiki/Template:Math_step "Template:Math step"))

## Example

From the [thruster mechanics](https://spaceengineers.wiki.gg/wiki/Thruster_mechanics "Thruster mechanics") page,

{{Math table
|formulas=
{{Math formula|1=a=\\frac {(L\_n L\_f + S\_n S\_f)} {m} }}
|definitions=
{{Math define|a|Acceleration (m/s<sup>2</sup>)}}
{{Math define|L\_n|Number of large thrusters}}
{{Math define|L\_f|Force of each large thruster (N)}}
{{Math define|S\_n|Number of small thrusters}}
{{Math define|S\_f|Force of each small thruster (N)}}
}}

results in...

|     |     |
| --- | --- |
| a\=(LnLf+SnSf)m |     |
| _Where:_ |     |
| a   | : Acceleration (m/s2) |
| Ln  | : Number of large thrusters |
| Lf  | : Force of each large thruster (N) |
| Sn  | : Number of small thrusters |
| Sf  | : Force of each small thruster (N) |

## See also

*   [Template:Math formula](https://spaceengineers.wiki.gg/wiki/Template:Math_formula "Template:Math formula") - Enter formulas.
*   [Template:Math define](https://spaceengineers.wiki.gg/wiki/Template:Math_define "Template:Math define") - Define variables
*   [Template:Math step](https://spaceengineers.wiki.gg/wiki/Template:Math_step "Template:Math step") - Demonstrate a process.
*   See [Wikipedia:Help:Displaying a formula using TeX](https://en.wikipedia.org/wiki/Help:Displaying_a_formula#Formatting_using_TeX "wikipedia:Help:Displaying a formula") for help with the TeX syntax.