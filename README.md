
<div align="center">
 
  <h1> Virtual Web Socket </h1>
  
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#beginner-about-the-project">About The Project</a></li>
    <li><a href="#hammer-requirements">Built With</a></li>
    <li><a href="#electric_plug-installation">Installation</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## :beginner: About The Project

Virtual Web Socket project using .NET that allows developers to test WebSocket functionality.
Virtual Web Socket project provides an endpoint through which developers can connect to a WebSocket channel from any application and send desired messages over WebSocket with the ability to specify the number of messages, time intervals, and content.
It serves as a useful tool for developers who want to experiment with WebSocket communication and validate the behavior of their applications in various scenarios. By facilitating easy and customizable message sending, the project simplifies the testing process and helps developers ensure the robustness and reliability of their WebSocket implementations.



## :hammer: Requirements

Technologies needed to get the project up and running

* [Docker](https://www.docker.com)

## :electric_plug: Installation

Follow the steps below to run the project in your local

1. Clone the repo
   ```sh
   git clone https://github.com/muhammetcagatay/virtual-web-socket
   ```
      
2. Go to project folder
   ```sh
   cd jwt-authentication/api
   ```
3. Create docker image and create and run docker container
   ```sh
   docker build -t virtual-web-socket .
   docker run -p 80:80 virtual-web-socket
   ```

## :earth_americas: Endpoints
Listening and serving API and WebSocket on : 80

The following url should be used to create a new websocket:
**ws://localhost:80/ws/channel/{channelName}**

#### The endpoint to be used to send the message
| Method | Path | Query Params | Body
| --- | --- | --- | --- |
| `POST` | `/api/socket/sendMessage` | **channelName :** The web socket channel name to which the message will be sent <br/>  **messageCount :** number of messages to be sent <br/> **interval :** time interval between messages| json model to be sent over web socket|



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png

