Feature: HotlineTest

Background: Pre-Conditions
Given User go to 'HotLineEnv'

#Scenario: User login on hotline resource 
#	When User login with 'TestUserHotLine@gmail.com' email and 'TestUser' password
#	Then User sees 'TestUser12' nickname instead of 'login' button

Scenario: User search product
	When User set 'iqos' text to 'search bar'
	Then User check that all displayed items has 'IQOS' text in name

Scenario: User select filters for the found products
	When User set 'iqos' text to 'search bar'
	When User select 'Електронні цигарки' sub-category
	When User select 'IQOS' filter for product
	When User waits '2' second
	When User select '900 і менше' filter for product
	When User waits '1' second
	When User go to 'selected filters'
	Then User check that selected 'IQOS' filter is displayed
	Then User check that selected '900 і менше' filter is displayed

Scenario: User add item to personal list 
	When User set 'iqos' text to 'search bar'
	When User clicks 'IQOS 3 DUO, The We Edition (DK000555.00)' product from 'search result' page
	When User add selected product to 'personal list'
	When User waits '2' second
	When User select 'Закладки' option from 'bookmark-list' dropdown
	When User clicks 'Зберегти' button in modal window
	When User waits '1' second
	When User go to 'personal list' from modal window
	Then User check that 'IQOS 3 DUO, The We Edition (DK000555.00)' product that added to personal list is displayed

Scenario:  User add items to compare 
	When User set 'iqos' text to 'search bar'
	When User select 'Електронні цигарки' sub-category
	When User waits '2' second
	When User add 'IQOS VEEV, Синий (DF001496.00)' product to 'compare'
	When User waits '2' second
	And User add 'IQOS VEEV, Графитовый (DF001497.00)' product to 'compare'
	When User clicks button by identifier '-compare'
	When User waits '2' second
	When User select 'Електронні цигарки' option from dropdown by dropdown class '-compare'
	Then User check that 'IQOS VEEV, Синий (DF001496.00)' product that added to comparison is displayed
	And User check that 'IQOS VEEV, Графитовый (DF001497.00)' product that added to comparison is displayed

Scenario: User sorts list of the found products
	When User set 'iqos' text to 'search bar'
	When User select 'Системи нагрівання тютюну' sub-category
	When User select 'новизною' option from 'select' dropdown
	Then User sees 'новизною' option for sorting selected previously

Scenario: User compare price for product in diffrent store 
	When User set 'iqos' text to 'search bar'
	When User clicks 'IQOS 3 DUO, черный (DK000495.00)' product from 'search result' page
	When User clicks 'compare price' button
	Then User sees list of the market with prices for selected product

Scenario: User search category
	When User go to 'all categories'
	When User select 'Системи нагрівання тютюну' category by 'тютюн' item name from autocomplete
	When User clicks 'Так, я старше 18 років' button in modal window
	Then User sees category header

Scenario: User check 'viewed product'
	When User set 'iqos' text to 'search bar'
	When User clicks 'IQOS 3 DUO, черный (DK000495.00)' product from 'search result' page
	When User waits '3' second
	When User clicks button by identifier '-listing'
	When User waits '3' second
	When User select 'Переглянуті товари' option from dropdown by dropdown class '-listings'
	Then User check that 'IQOS 3 DUO, черный (DK000495.00)' product that added to personal list is displayed

Scenario: User select another city
	When User clicks 'select city' button
	When User set 'Харків' city name to search bar
	When User waits '2' second
	When User select 'Харків,' city
	When User waits '1' second
	Then User sees 'Харків' city in geo tag
