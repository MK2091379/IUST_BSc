#include <stdio.h>
#include <sys/socket.h>
#include <unistd.h>
#include <stdlib.h>
#include <netinet/in.h>
#include <string.h>

#include <pthread.h>
void* get_response(void* p);

// in your browser type: http://localhost:8090
// IF error: address in use then change the PORT number
#define PORT 8090

struct arg_struct {
    int socket;
};

char *hello = "HTTP/1.1 200 OK\nContent-Type: text/plain\nContent-Length: 12\n\nHello world!";
int server_fd, new_socket; long valread;
int main(int argc, char const *argv[])
{
    struct sockaddr_in address;
    int addrlen = sizeof(address);
    pthread_t id;
    
    
    if ((server_fd = socket(AF_INET, SOCK_STREAM, 0)) == 0)
    {
        perror("In socket");
        exit(EXIT_FAILURE);
    }
    

    address.sin_family = AF_INET;
    address.sin_addr.s_addr = INADDR_ANY;
    address.sin_port = htons( PORT );
    
    memset(address.sin_zero, '\0', sizeof address.sin_zero);
    
    
    if (bind(server_fd, (struct sockaddr *)&address, sizeof(address))<0)
    {
        perror("In bind");
        exit(EXIT_FAILURE);
    }
    if (listen(server_fd, 10) < 0)
    {
        perror("In listen");
        exit(EXIT_FAILURE);
    }
    while(1)
    {
        printf("\n+++++++ Waiting for new connection ++++++++\n\n");
        if ((new_socket = accept(server_fd, (struct sockaddr *)&address, (socklen_t*)&addrlen))<0)
        {
            perror("In accept");
            exit(EXIT_FAILURE);
        }
        
        char buffer[30000] = {0};
        valread = read( new_socket , buffer, 30000);
        printf("%s\n",buffer );
        pthread_create(&id, NULL, get_response, (void *)&new_socket);
    }
    return 0;
}
void* get_response(void* p)
{
    int socket_id = *(int *)p;
    sleep(5);
    printf("\nsocket_id: %d\n",socket_id);
    printf("-------------Hello message sent---------------");
    write(socket_id , hello , strlen(hello));
    close(socket_id);
}

