# api.ai sample project in .NET
## Background 
api.ai is a platform that provides functionalities in three domains 
*  integration with social medias, IOT. etc 
*  add AI power on top of the communication between service provider and social media/IOT. 
*  provide a workflow framework

## Project Description
This project simulates a booking workflow combining api.ai + facebook messenger. The .NET project itself acts as webservice endpoint (weebhook). 
There are some steps you need to follow in order to recreate the complete environment 
*  **bookbot.postman_collection.json** - after downloading the project, you feed this json to postman to test out the endpoint locally, if you can result "[]" then it is good
*  **bot_backup.zip** - you can recreate the bot agent on api.ai by upploading this zip file, then all the "entities" and "intents" etc will be ready
*  after creating agent by upploading the zip file, you need to replace the endpoint address in the "Fulfillment" section, point to the .net web api application that is deployed

## User Story Description
*  step1 - user types "i want to book a single room" or "i want to book a double room", then facebook messenger will display different room image
*  step2 - user types ex "two adults and one kid, check in 2017-11-11, check out 2017-11-14", then facebook messenger will display a confirmation message including the room that is picked, number of adults/children, checkin date/checkout date. we can also write things like "we are 10 adults and 1 kid, checkin date at 2017-11-11 and checkout date at 2017-12-01" or <br/>"we are a family with 2 persons and 1 child, checkin date at 2017-11-11 and checkout date at 2017-12-01"<br/> Here is where the AI kicks in, it sees "child" as "kid"


A few technical level bullet points here
* in each step above, facebooking messenger communicates with our hosted webservice through api.ai. communication is two ways
* information gathered from step1 is saved into api.ai context and get passed further to step2
* step2 will not be triggered unless step1 is triggered
