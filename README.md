<div align="center">

  <h1> JWT Authentication </h1>

</div>


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/muhammetcagatay/VivaceAPI">
    <img src="http://jwt.io/img/logo-asset.svg" alt="Logo" width="400">
  </a>

  <p align="center">

  </p>
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

<div align="center">



https://user-images.githubusercontent.com/57941950/194851987-6bb7cd6b-39c9-41ba-a076-453c67709d46.mp4

</div>

The main idea of ​​creating this project is to create JWT Authentication system using .Net Core and React technologies.

* When the application is run, the client makes a request to the server with email and password information. If the email and password information is correct, access token and refresh token are returned to the client.
* It makes a request to an enpoint that is authorized on the server along with the client access token. If the access token is correct, the information is responded to the client.
* In case the access token expires, the client makes a request to the server with a refresh token and the server returns a new access token in return.




## :hammer: Requirements

Technologies needed to get the project up and running

* [ASP.Net Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
* [Docker](https://www.docker.com)
* [npm](https://nodejs.org/en/download/)

## :electric_plug: Installation

Follow the steps below to run the project in your local

1. Clone the repo
   ```sh
   git clone https://github.com/muhammetcagatay/jwt-authentication.git
   ```

2. Create SQL Server Docker container
   ```sh
   docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=password123*" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
   ```

3. Go to project folder
   ```sh
   cd jwt-authentication/api
   ```
4. Restore and run api
   ```sh
   dotnet restore
   dotnet run
   ```
5. Open new terminal and install npm packages 
   ```sh
   cd client
   npm install
   ```

5. Run Client
   ```sh
   npm start
   ```

## :earth_americas: Endpoints
Listening and serving API Gateway HTTPS on : 5001

| Method | URL | Description |
| --- | --- | --- |
| `POST` | `/api/auth/login` | `Returns of Access Token and Refresh Token` |
| `POST` | `/api/auth/refreshToken` | `Returns of new Access Token and Refresh Token` |
| `GET - Authorize` | `/api/home` | `Returns the "Giriş Başarılı" message` |



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
