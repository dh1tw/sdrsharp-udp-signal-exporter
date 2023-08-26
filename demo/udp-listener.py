# run with python3

# original script published by 'pufferbatterie' on Stackoverflow:
# https://stackoverflow.com/questions/68762495/easiest-way-to-receive-udp-packets

import socketserver  # we use the socketsever module that comes with python3

class MyUDPHandler(socketserver.DatagramRequestHandler):

    def handle(self):
        print("Got an UDP Message from {}".format(self.client_address[0]))

        msgRecvd = self.rfile.readline().strip().decode("utf-8")
        values = msgRecvd.split(";")

        print("Floor: {}dbFS".format(values[0]))
        print("Peak:  {}dbFS".format(values[1]))
        print("S/N:   {}db".format(values[2]))

# this is the main entrypoint
if __name__ == '__main__':
    # we specify the address and port we want to listen on
    listen_addr = ('0.0.0.0', 9988)

    # with allowing to reuse the address we dont get into problems running it consecutively sometimes
    socketserver.UDPServer.allow_reuse_address = True 

    # register our class
    serverUDP = socketserver.UDPServer(listen_addr, MyUDPHandler)
    serverUDP.serve_forever()