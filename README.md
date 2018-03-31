article
https://www.3pillarglobal.com/insights/develop-microservices-net-core-docker

Issue #1:
Can't access api from  localhost with assigned port

Solution #1 :
Try following steps,

1 - List all the running docker containers

docker ps -a
After you run this command you should be able to view all your docker containers that are currently running and you should see a container with the name webapp_web_1 listed there.

2 - Get the IP address where your webserver container is running. To do that run the following command.

docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" webapp_web_1
Try accessing the IP which is shown after running above command and access your running container with that IP instead of localhost.