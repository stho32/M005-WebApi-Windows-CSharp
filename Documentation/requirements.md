# "prov" Provisioning infrastructure and development environments

## Requirements

- [X] There is a web api

(In this case I do not really want to have a webapi project. Instead I want to use a subfolder of this project and provide json-Files there that are interpreted. This way I can use github as my central repository for computer descriptions.)

- [X] The api defines the following commands: 
    - [X] get a list of recipes from the host
    - [X] get a recipe with all details
        - [X] the recipe contains descriptions for 1..n hosts (host-description)
        - [X] host-descriptions contain a list of tasks
        - [X] a task can be:
            - [X] an application to execute
            - [ ] an application to install
            - [X] a cmdline / powershell-command to be executed
        - [X] each task has the information attached if it is executed in admin or user space

- [ ] There is a console application
    - [ ] the application provides a simple interface to choose a recipe and a host-description
    - [ ] for each step the application creates a shell in either admin or userspace, wherein the command is executed
    
