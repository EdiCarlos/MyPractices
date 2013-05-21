
#include <windows.h>
#include <winsock.h>
#include <iostream>

using namespace std;

SOCKET socket;

bool ConnectToHost(int portNumber, char* IpAddress)
{
 WSAData wsaData;
   int error = WSAStartup(0x0202, &wsaData);
   if(error)
	   return false;
   if(wsaData.wVersion == 0x0202)
   {
	   WSACleanup();
	   return false;
   }
   SOCKADDR_IN target;
   target.sin_family = AF_INET;
  // target.sin_addr.S_un = inet_addr(IpAddress);
   target.sin_port = htons(portNumber);

   //socket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);

//   if(socket == INVALID_SOCKET)
//   {
//    return false;
//   }
//   if(connect(socket, (SOCKADDR*)&target, sizeof(target) == SOCKET_ERROR))
//   {
//	   return false;
//   }
//   else
//   {
//  return true;
//   }
}
void CloseConnection()
{
	if(socket)
		closesocket(socket);
	WSACleanup();
}
int main()
{

	return 0;
}
