# Exempel med att visa och läsa in data via checkboxar
Ett litet MVC-projekt, som använder tre modeller:
* Person (namn, samt "skillset", kommaseparerad lista med kompetenser)
* Skill (namn på kompetens)
* PersonViewModel (vymodell, med PersonId, Namn, Lista med Skills samt en array med textsträngar (vilka skills som valts i formuläret))

## Notering
Det är enbart "Create" som är skapat i controllern för Person, går med fördel använda samma teknik med checkboxar även för "Edit"-vyn.

### Av
Mattias Dahlgren, 2023
mattias.dahlgren@miun.se
