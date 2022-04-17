# "prov" Provisioning infrastructure and development environments

The project is based on these [Requirements](Documentation/requirements.md) and is considered https://github.com/stho32/Training .

## What is this?

When developing software in a team you will need an application that helps you with the setup of infrastructure. 

You will need production machines, test environments, staging systems, development machines and so on. 

You will need to provision these. This is where M005 "prov" comes into play.

The task for this project is to provide a webapi, so what might that be? For the moment I would think that such a system would be a communication hub. 

And there is a very specific thing in windows that I have been thinking about for a longer time now: The unavailability of a sudo like tool. This implementation therefor should focus on an executable that, using a webapi, can retrieve actions to set up a computer and process them in 2 different ways: 
  - as a user
  - as an admin


## Badges

- [ ] Add a badge from the build workflow
- [ ] Add a badge from https://www.codefactor.io/
- [ ] Add a badge from sonarcloud
    - [ ] Code coverage
    - [ ] Lines of code
    - [ ] Maintainability rating
    - [ ] Security rating
    - [ ] Reliability rating



