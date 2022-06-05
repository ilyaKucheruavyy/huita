Feature: BDDTests

Background: Pre-Conditions 
Given User go to 'etsyEnv'
@tag
Scenario: Etsy
When User go to 'Игрушки и развлечения' menu
When User go to 'Фильмы и музыка' sub menu
When User searach product 'какое то имя продукта'
When User sorted product by 'Последние'
When User choose some filters
When User click to first product
When User select product
