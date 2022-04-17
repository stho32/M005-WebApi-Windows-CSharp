# "prov" Provisioning infrastructure and development environments

## Requirements

- [ ] There is a web api

(In this case I do not really want to have a webapi project. Instead I want to use a subfolder of this project and provide json-Files there that are interpreted. This way I can use github as my central repository for computer descriptions.)

- [ ] The api defines the following commands: 
    - [ ] get a list of recipes from the host
    - [ ] get a recipe with all details
        - [ ] the recipe contains descriptions for 1..n hosts (host-description)
        - [ ] host-descriptions contain a list of tasks
        - [ ] a task can be:
            - [ ] an application to execute
            - [ ] an application to install
            - [ ] a cmdline / powershell-command to be executed
        - [ ] each task has the information attached if it is executed in admin or user space

- [ ] There is a console application
    - [ ] the application provides a simple interface to choose a recipe and a host-description
    - [ ] for each step the application creates a shell in either admin or userspace, wherein the command is executed
    
