<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]


<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/MichelMichels/VatSharp">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">VatSharp</h3>

  <p align="center">
    A C# client to facilitate the validation of VAT data through <a href="https://ec.europa.eu/taxation_customs/vies/#/vat-validation">VIES (Vat Information Exchange System)</a>.
    <br />
    <a href="https://github.com/MichelMichels/VatSharp"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/MichelMichels/VatSharp/issues">Report Bug</a>
    ·
    <a href="https://github.com/MichelMichels/VatSharp/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Table of Contents</h2></summary>
  <ol>    
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

* [.NET 7](https://dotnet.microsoft.com/en-us/download)

<!-- USAGE EXAMPLES -->
## Usage

_//TODO_

<!-- DOCUMENTATION -->
## Official documentation

> :informational_source: This documentation is straight copied and formatted from https://ec.europa.eu/taxation_customs/vies/services/checkVatService.wsdl.

The objective of this Internet site is to allow persons involved in the 
intra-Community supply of goods or of services to obtain confirmation of the 
validity of the VAT identification number of any specified person, 
in accordance to article 31 of Council Regulation (EC) No. 904/2010 of 7 October 
2010.

Any other use and any extraction and use of the data which is not in conformity 
with the objective of this site is strictly forbidden. 
Any retransmission of the contents of this site, whether for a commercial 
purpose or otherwise, as well as any more general use other than as far as is 
necessary to support the activity of a legitimate user (for example: to draw up 
their own invoices) is expressly forbidden. 

In addition, any copying or reproduction of the contents of this site is 
strictly forbidden. 

The European Commission maintains this website to enhance the access by taxable 
persons making intra-Community supplies to verification of their customers' VAT 
identification numbers. 

Our goal is to supply instantaneous and accurate information. However the 
Commission accepts no responsibility or liability whatsoever with regard to the 
information obtained using this site. 

This information: 
* is obtained from Member States' databases over which the Commission services have no control and for which the Commission assumes no responsibility; it is the responsibility of the Member States to keep their databases complete, accurate and up to date; 
* is not professional or legal advice (if you need specific advice, you should 
always consult a suitably qualified professional); 
* does not in itself give a right to exempt intra-Community supplies from Value 
Added Tax; 
* does not change any obligations imposed on taxable persons in relation to 
intra-Community supplies. 

It is our goal to minimise disruption caused by technical errors. However some 
data or information on our site may have been created or structured in files or 
formats which are not error-free and we cannot guarantee that our service will 
not be interrupted or otherwise affected by such problems. The Commission 
accepts no responsibility with regard to such problems incurred as a result of 
using this site or any linked external sites. This disclaimer is not intended to 
limit the liability of the Commission in contravention of any requirements laid 
down in applicable national law nor to exclude its liability for matters which 
may not be excluded under that law. Collecting or handling personal data falls 
under the Data Protection Notice. This data protection declaration explains the 
Processing in the VIES-on-the-web Internet Website of VAT Identification Numbers 
for intra-Community Transaction on Goods or Services. Details of your legal 
rights associated with the collection, processing and use of this data are also 
provided: http://ec.europa.eu/dpo-register/details.htm?id=40647. 

Usage: 
* The countryCode input parameter must follow the pattern `[A-Z]{2}` 
* The vatNumber input parameter must follow the pattern 
`[0-9A-Za-z\+\*\.]{2,12}` 

In case of problems, the returned `FaultString` can take the following specific 
values: 

| Value                       | Description                                                                                                                                                                                                                                                                                                                                                                  |
| --------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `INVALID_INPUT`             | The provided CountryCode is invalid or the VAT number is empty.                                                                                                                                                                                                                                                                                                              |
| `GLOBAL_MAX_CONCURRENT_REQ` | Your Request for VAT validation has not been processed; the maximum number of concurrent requests has been reached. Please re-submit your request later or contact TAXUD-VIESWEB@ec.europa.eu for further information": Your request cannot be processed due to high traffic on the web application. Please try again later.                                                 |
| `MS_MAX_CONCURRENT_REQ`     | Your Request for VAT validation has not been processed; the maximum number of concurrent requests for this Member State has been reached. Please re-submit your request later or contact TAXUD-VIESWEB@ec.europa.eu for further information": Your request cannot be processed due to high traffic towards the Member State you are trying to reach. Please try again later. |
| `SERVICE_UNAVAILABLE`       | An error was encountered either at the network level or the Web application level, try again later.                                                                                                                                                                                                                                                                          |
| `MS_UNAVAILABLE`            | The application at the Member State is not replying or not available. Please refer to the Technical Information page to check the status of the requested Member State, try again later.                                                                                                                                                                                     |
| `TIMEOUT`                   | The application did not receive a reply within the allocated time period, try again later.                                                                                                                                                                                                                                                                                   |

<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/MichelMichels/VatSharp/issues) for a list of proposed features (and known issues).


<!-- CONTRIBUTING -->
## Contributing

If you wnat to contribute, please follow next steps:

1. Open an issue with your proposed changes
2. Fork the repository
3. Create your Feature Branch (`git checkout -b {issue-number}-{feature-description}`)
4. Commit your Changes (`git commit -m 'Fix #{issue-number} - Add some {feature}`)
5. Push to the Branch (`git push origin {issue-number}-{feature-description}`)
6. Open a Pull Request

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<!-- CONTACT -->
## Contact

If you want to contact me, you can open a discussion on this project.

Project Link: [https://github.com/MichelMichels/VatSharp](https://github.com/MichelMichels/VatSharp)



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/MichelMichels/repo.svg?style=for-the-badge
[contributors-url]: https://github.com/MichelMichels/repo/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/MichelMichels/repo.svg?style=for-the-badge
[forks-url]: https://github.com/MichelMichels/repo/network/members
[stars-shield]: https://img.shields.io/github/stars/MichelMichels/repo.svg?style=for-the-badge
[stars-url]: https://github.com/MichelMichels/repo/stargazers
[issues-shield]: https://img.shields.io/github/issues/MichelMichels/repo.svg?style=for-the-badge
[issues-url]: https://github.com/MichelMichels/repo/issues
[license-shield]: https://img.shields.io/github/license/MichelMichels/repo.svg?style=for-the-badge
[license-url]: https://github.com/MichelMichels/repo/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/MichelMichels
