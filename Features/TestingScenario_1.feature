Feature: FlightReservationUITest
	Test Flight Reservation System

@BookTicket
Scenario: Book One Way Ticket
	Given Navigate to URL 'http://newtours.demoaut.com/mercurywelcome.php'
	And Login into find a Flight authentication with Username 'mercury' and Password 'mercury'
	When Main Page is shown Select One Way radio button
	Then Select Depart from 'Sydney' and Arrive to 'London'
	And Select 'First' Class
	Then Click continue and navigate to Select Flight Page
	And Select Flight
	Then Enter 'FirstName' and 'LastName'
	And Provide Credit Card Details and check TicketLess Travel
	Then Click the Secure Purchase Button to finish booking