# Citizen Single Sign On - GovIT Hub Authenticator [![Build Status](https://travis-ci.org/gov-ithub/auth-sso.svg?branch=master)](https://travis-ci.org/gov-ithub/auth-sso) 
Un singur set de credențiale pentru cetățean. La bază este un identity server ce expune un endpoint Outh2.

## Instalare
- branch from master
- create database sso
- create file `./src/GotITHub.Auth.Identity/connectionstrings.json` containing the connection string to the database like in example below:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;userid=<user id>;pwd=<password>;port=3306;database=sso;sslmode=none;"
  }
}
```

### Identity server
- open shell (command promt)
- go to \\govithub-auth-sso\src\GovITHub.Auth.Identity
- `dotnet restore`
- `dotnet ef database update`
- `dotnet run`

### Javascript client sample
- open shell (command prompt)
- go to \\govithub-auth-sso\src\samples\JavaScriptClient
- `npm install`
- `dotnet run`

## Tehnologii folosite
- [Identity Server](https://identityserver.io/)
- [.NET Core](https://www.microsoft.com/net/core)
- [AngularJS](https://angularjs.org/)
- [Docker](https://docs.docker.com/engine/installation/)
- [npm](https://github.com/npm/npm)
- [1][MySQL](http://www.mysql.com/)

```
[1] Posibil să se schimbe în viitorul apropiat
```

### Extra techs (folosite la SDKs, samples & integration)
- [React](https://facebook.github.io/react/)
- [PHP](http://www.php.net/)
- [Java SE] (http://www.oracle.com/technetwork/java/javase/overview/index.html)
- [Java EE](http://www.oracle.com/technetwork/java/javaee/overview/index.html)
- [Python] (https://www.python.org/)
- Others :-)

## Contribuie

Dacă vrei să contribui - ești binevenit(ă) - but we don't have cookies (yet) 

### Proces
- Vezi lista de tehnologii folosite - îți sunt familiare?
- Dacă nu ești încă înscris(ă) în comunitate, te rog fă-o pe [site-ul de voluntari GovITHub](# Aplicatie mobila pentru ANAF [![Build Status](https://travis-ci.org/gov-ithub/anaf-mobile.svg?branch=master)](https://travis-ci.org/gov-ithub/anaf-mobile) 
Aplicatie mobila pentru ANAF

## Instalare
To be updated

## Tehnologii folosite
- [Ionic 2] (http://ionicframework.com/), [docs] (http://ionicframework.com/docs/v2/)
- [AngularJS 2] (https://angular.io/)
- [Cordova] (https://cordova.apache.org/)

## Development IDE & tools:
- Recomandat [Visual Studio Community], vine cu cordova si ripple
- Alte IDE-uri pot fi folosite

## Contribuie

Dacă vrei să contribui - ești binevenit(ă) - but we don't have cookies (yet) 

### Proces
- Vezi lista de tehnologii folosite - îți sunt familiare?
- Dacă nu ești încă înscris(ă) în comunitate, te rog fă-o pe [site-ul de voluntari GovITHub](http://voluntari.ithub.gov.ro/)
- Aruncă o privire la [guidelines](https://github.com/gov-ithub/guidelines/blob/master/CODE_REVIEW.md) pentru code review 
- Caută în issues un task interesant pentru tine (sau, dacă ai o propunere, deschide un issue / trimite un pull request). 
- După ce trecem prin code review - celebrate! :star: :star2: :star:

## Cum poti intra in contact cu echipa?
- Email: alexandru.chiraples@ithub.gov.ro
- Slack: @alex.chiraples. Pentru invite intrați pe http://govitslack.herokuapp.com/

Mai multe detalii în curând! 
)
- Aruncă o privire la [guidelines](https://github.com/gov-ithub/guidelines/blob/master/CODE_REVIEW.md) pentru code review 
- Caută în issues un task interesant pentru tine (sau, dacă ai o propunere, deschide un issue / trimite un pull request). 
- După ce trecem prin code review - celebrate! :star: :star2: :star:

## Cum poti intra in contact cu echipa?
- Email: alexandru.chiraples@ithub.gov.ro
- [Slack](https://govithub.slack.com/messages/gov-authenticator/details/). Pentru invite intrați pe http://govitslack.herokuapp.com/

Mai multe detalii în curând! 
