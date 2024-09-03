---
marp: true
paginate: true
theme: default 
header: ![h:35](imgs/starwit.png)
footer: 'Starwit Technologies GmbH | C#'
---

<style>
header {
  text-align: right;
  font-size: 0.7rem;
  color: #bbb;
  margin: 20px;
  left: 0px;
  right: 0px;
  padding-top: 5px;
}
footer {
  font-size: 0.9rem;
  color: #666;
}
section.lead {
  text-align: center;
  margin-bottom: 40px;
}
section {
  font-size: 1.5rem;
}
section.lead h1 {
  font-size: 2.5rem;
  font-weight: 600;
}
section.linked footer {
  display: none;
}
section.linked header {
  display: none;
}
section.quote {
  font-size: 0.7rem;
  text-align: center;
  font-style: italic;
  color: #555;
}

h1 {
  position: absolute;
  top: 10px;
  padding-top: 15px;
  text-transform: uppercase;
  font-size: 2.0rem;
  font-weight: 500;
  color: #2B5A6A;
}

h2 {
  font-size: 2.0rem;
  font-weight: 500;
  color: #2B5A6A;
  margin-top: 30px;
  margin-bottom: 15px;
}
a {
  color: #3A9FC1;
}
a:hover {
  color: #1E708B; 
  text-decoration: underline; 
}

</style>

# 1. Tools, Setup & .NET
## Agenda   
* Introduction to C# & the .NET runtime (slides)
* Git & why version management is crucial (slides)
* Visual Studio & the role of the IDE (discussion)
* MSBuild & how to build softwares (task)
* Hello World! (task)

---
# 1. Tools, Setup & .NET
## .Net

* Free == free available
* Open source == you can get source code and participate on development
* Cross-platform == works on Linux, MacOS, Windows
* Development platform 
    * runtime for programming languages **C#** and F#
    * libraries and development tools for application development

---
# 1. Tools, Setup & .NET
## .Net != .Net Framework

|.Net|.Net Framework|
|---|---|
|runs on Linux, MacOS, Windows|only runs on Windows|
| has to be installed | included in Windows |
|**recommanded for new development** |

> https://learn.microsoft.com/de-de/shows/dotnet-for-beginners/what-is-dotnet-dotnet-for-beginners

---
# 1. Tools, Setup & .NET
## What can you do with .Net?

* you can run and develop:
  * Web applications
  * Mobile and desktop applications
  * Cloud-native apps

---
# 1. Tools, Setup & .NET
## C#

* Developed in 2002 by Anders Hejlsberg on behalf of Microsoft as part of the .NET strategy
* platform-independent
* object-oriented

---
# 1. Tools, Setup & .NET

## Tools
* Visual Studio
* Visual Studio Code

## Links
* https://learn.microsoft.com/de-de/shows/dotnet-for-beginners/what-is-dotnet-dotnet-for-beginners
* https://de.wikipedia.org/wiki/.NET_(Plattform)#Programmiersprachen


---
# 1. Tools, Setup & .NET
## Visual Studio Code
![h:400](../imgs/vs-code-extension.png)
add extension

---
# 1. Tools, Setup & .NET

![h:400](../imgs/vs-code-new-project.png)
create new project

---
# 1. Tools, Setup & .NET
## Git

* in order to work together, you need to handle parallel changes of your team
* Git is a version control system designed to do this
* you work with branches e.g. to separate different features from each other
* important commands:
  * `git clone https://...` clones a project from a git repository to your lokal file system
  * `git add .` adds your changes to a stage
  * `git commit .` commits your changes in your local branch
  * `git push` pushes your changes to remote branch
  * `git pull` get the latest changes from your repository

---
# 1. Tools, Setup & .NET
## Installing packages with Nuget

* Why: Using other peoples code via packages
* Why a package manager:
  * tool for adding, deleting packages for your entire project independent of local machine
* go to [nuget.org](Nuget.org) and search e.g. for PasswordGenerator