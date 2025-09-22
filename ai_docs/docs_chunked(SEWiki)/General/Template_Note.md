---
title: "Template:Note"
url: "https://spaceengineers.wiki.gg/wiki/Template:Note"
category: "General"
wiki_page: "Template:Note"
---

# Template:Note - Official Space Engineers Wiki

## Description

{{Note}} is used to insert a box that highlights text as a note, info, warning, or error.

## Syntax

{{Note|notetext=lorem ipsum.|type=note}}

{{Note|notetext=lorem ipsum.|type=info}}

{{Note|notetext=lorem ipsum.|type=warning}}

{{Note|notetext=lorem ipsum.|type=error}}

## Usage

{{Note|notetext=Hallo dies ist ein Infotest.|type=info}}

Hallo dies ist ein Infotest.

  
{{Note|notetext=Hallo dies ist ein Notetest.|type=note}}

Hallo dies ist ein Notetest.

  
{{Note|notetext=Hallo dies ist ein Warningtest.|type=warning}}

Hallo dies ist ein Warningtest.

  
{{Note|notetext=Hallo dies ist ein Errortest.|type=error}}

Hallo dies ist ein Errortest.

  
{{Note|notetext=Hallo dies ist ein Default-Test. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.}}

Hallo dies ist ein Default-Test. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

  
{{Note|notetext=Hallo dies ist ein absolutely crazy Test.  
\*Here's  
\*even  
\*a list  
and a {{Spoiler}} all in the note!  
}}

Hallo dies ist ein absolutely crazy Test.

*   Here's
*   even
*   a list

and a

**Spoiler warning!**  
This article or section contains details about the game which players may be intended to discover on their own!

all in the note!

Use the Note template to insert a box that highlights text as a note, info, warning, or error.

|     |     |     |     |     |
| --- | --- | --- | --- | --- |
Template parameters\[[Edit template data](https://spaceengineers.wiki.gg/wiki/Template:Note?action=edit&templatedata=edit "Template:Note")\]
| Parameter |     | Description | Type | Status |
| --- | --- | --- | --- | --- |
| type | `type` | Defines the color and icon of the note box.<br><br>Suggested values<br><br>`info` `note` `warning` `error`<br><br>Default<br><br>Note | String | suggested |
| Content | `notetext` `content` | Defines the content text of the note box.<br><br>Example<br><br>When flying at high speed, do not aim straight at asteroids. | String | required |