# Classic Online
PO Baseline mode included is called "Classic Online". Classic Online includes an attempted recreation of GTA:Online as it was in 2013, this includes many of the original features from 2013 with some tweeks and addions. The aim with Classic Online was to preserve what GTA:Online looked like in 2013 with the added ability of fixing some issues and deviating when R* code does not work in the FiveM env. 

Included with Classic Online and as a base modual that can be lifted out is a light weight script modual that allows you to develop mission scripts that utlize the APIs you write. These scripts are ment to be
created, run, do stuff then tided up by the system itself. If you dont want to create something heavy, this is right way to create something light.

## Components
The way i've tackled this issue is by treating the client as the defacto area to develop in. The server serves only 1 purpose, action and callbacks. Inside the included server access libaries are methods you would
find as basic read write file, console write and http calls. This is because the client cant do all that stuff since its sandboxed, so the server needs to do it and return a result back.

for http calls, to avoid the server being overloaded and slowing things down. Calls to a dabase should be done via a web api using .net core. Included in the code folder is the components i've made that are needed to make Classic Online work. You may build and run these to get your version up and running.

## Development Ontop of Classic Online
You can develop ontop of classic online without needing to touch the original resource code. The solution was built with that in mind. Developing new moduals, levelscripts or global libraries is easy. You can use
the libraries such as: 

Modualization (to create new client moduals, drop these into the base client resource)
Access (if you want to create APIs for the server, drop these into the base server resource)
ResourceLibs (to develop new Resources, drop these into the resources folder and load them like normal FiveM Resources) 
CoreExtended (if you wish to use addional objects layered ontop of GTA:V, levelscripts using this will be dropped into the base client resource) 

You can develop your new resources, moduals, levelscripts or global libraries into the ext folder to keep them out of the way.

## Repo
Code - resource, libs, tools and components are based in here. Everything to make the 'base' level function
Data - Data that refers to resource data files, database scripts and component data
Ext - Ext is for non resource code bases, levelscripts and modules go here
Vendor - dlls and 3rd party libraries used by code or ext.

