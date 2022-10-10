
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
    <li><a href="#hammer-built-with">Built With</a></li>
    <li><a href="#electric_plug-installation">Installation</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## :beginner: About The Project

<div align="center">



https://user-images.githubusercontent.com/57941950/194851987-6bb7cd6b-39c9-41ba-a076-453c67709d46.mp4



</div>




The main idea of ​​creating this project is to implement Microservices Architecture with  latest technology such as .Net 6, MongoDB, PostgreSQL, Docker. There are two services and one API Gateway in the project.

* The Movie service uses MongoDB as its database. Movie service is a service that allows us to process movies, actors and categories.
* The book service uses PostgreSQL as its database. The Book service is a service that allows us to perform operations on books, authors and categories.
* API Gateway is an API Management tool that stands between clients and microservices. Ocelot used as library in API Gateway



## :hammer: Requirements

Technologies needed to get the project up and running

* [ASP.Net Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
* [Docker](https://www.docker.com)
* [npm](https://docs.npmjs.com/cli/v8/commands/npm-install)

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

