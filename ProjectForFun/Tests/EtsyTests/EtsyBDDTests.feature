Feature: BDDTests

Background: Pre-Conditions 

@tag
Scenario: Etsy
Given User go to 'https://www.etsy.com/'

When User go to 'Игрушки и развлечения' menu
When User go to 'Фильмы и музыка' sub menu
When User searach product 'какое то имя продукта'
When User sorted product by 'Последние'
When User choose some filters
When User click to first product
When User select product
