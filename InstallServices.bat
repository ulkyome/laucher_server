cd RCClient
RCClientService.exe -install
cd ..
cd RCServer
RCServerService.exe -install
NET START "Remote Control Client Service"
NET START "Remote Control Server Service"