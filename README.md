# Tumblr + Pinterest clone

**Objective**: Full stack application that shows personal uploaded images/videos/music in a mosaic/or tumblr like cards.

## User Stories

1. User Story: As an unauthenticated user, I can login with a normal account(token based) or with Facebook/Github. For the moment: max accounts number = 2.
2. User Story: As an authenticated user, I can link to images.
3. User Story: As an authenticated user, I can delete images that I've linked to.
4. User Story: As an authenticated user, I can see a Pinterest-style wall of all the images I've linked to.
5. User Story: As an authenticated user, I can see a personal Tumblr like list of images.
5. User Story: As an unauthenticated user, I can browse other users' walls of images.
6. User Story: As an authenticated user, if I upload an image that is broken, it will be replaced by a placeholder image. (can use jQuery broken image detection)
7. Customizable theme

## Main technologies front end
1. React.js + Redux
2. Typescript
3. Masonry.js
4. React Bootstrap
5. Maybe storybook - for trying to develop new component 

## Main frotend components

1. Comment component
2. Masonry grid
3. Tumblr like card
4. User profile
5. Search box with filters for images, videos, music
6. Navigation bar / sidebar


## Main API routes 



## Main technologies backend
1. ASP.NET core
2. Entity core framework


## Main domains

1. Users
2. Photos - 1 to 1 relationship with the User
3. Comments - n to 1 relationship with the User


# API Endpoints

## Photos

|     API                 | Description                           | Request body | Response body   |
|-------------------------| --------------------------------------| ------------ | ----------------|
| GET /api/Photos         | get all photos                        | none         | array of photos |
| GET /api/Photos/{id}    | get a photo by Id                     | none         | photo           |
| POST /api/Photos        | upload new photo                      | photo        | photo metadata  |
| PUT /api/Photos/{id}    | update an existing photo(name, frame) | photo        | none            |
| DELETE /api/Photos/{id} | delete an existing photo              | none         | none            |

## Comments

|     API                           | Description                           | Request body | Response body     |
|-----------------------------------|---------------------------------------| ------------ | ------------------|
| GET /api/Comments/{photoId}       | get all comments by photo id          | none         | array of comments |
| POST /api/Comments/{photoId}      | add new comment                       | comment      | array of comments |
| PUT /api/Comments/{photoId}       | update an existing comment            | comment      | none              |
| DELETE /api/Comments/{photoId}    | delete an existing comment            | none         | none              |


## Like/dislike system

|     API                                | Description                           | Request body | Response body     |
|----------------------------------------|---------------------------------------| ------------ | ------------------|
| POST /api/Photos/{photoId}/like?liked={something}        | like a photo                          | none         | like              |            

## User authentication



# JWT Token

* Header - what token is - typ, alg(hashing alghoritm)
* Payload
    - data stored inside jwt
    - nbf - not before
    - exp - expire date
    - iat - issued at date
* Signature
    -  server uses to verify if token is valid and not modified
    - when server sends the token out it is encrypted with the algorithm

- access resource with token 
