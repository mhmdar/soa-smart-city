# soa-smart-city

Parking management system is a tool that will operate as utility as part of of the vision of a smart city where it helps drivers who seek a best parking lots. The system exploits the information obtained from the user’s location as well as some necessary information from sensors deployed at the city’s parking lots in order to find the best parking lot for the driver’s location depending on the traffic.
The goal is to build an internet of things system that interact with many devices around the city, in order to provide the best reliable service.


The business objective of such system to optimizes the utilization of the city parking lots as well as saving the effort and time of the drivers seeking parkings, and achieving the max profit for the parkings owners.
We tried to reflect the concept of composite APIs in a manner that serves the business objective of the project.
The services that the system provide are:
Search for a list of the best available parking lots according to many motrics like the user preferences represents cost of the maximum cost the user can pay, location of available lots and the status of traffic in the surrounding streets.
Choose one of the best available parking lots and reserve it for a certain period of time. This will end up deducting the cost from the user’s balance and updating the status of the reserved parking lot sensor.

Architectural Diagram:
The system is intended to follow the client-server architecture, where the end user enjoys the service through his mobile device that has the mobile client deployed on it. The server side contains that business logic that handles the algorithms that fulfills his requirements. The interaction between the client and the server (which also requires interaction with the database) implemented using web services APIs.

The figure below shows an abstract version of the system architecture:



In this architecture, the mobile device represents the service consumer, and the server side represents the service provider.

The system designed to provide an optimized heuristic search for the best available slots. The results will be improved using a genetic algorithm that will build the gens based on many metric, The distance, cost, profit , and traffic jams.
 
The architecture above will have the following processes with atomic services encapsulated within them and interact as follows:

- “GetBestParkingLots”   process: this process provides the end user with a list of the best parking lots available according to certain criteria(Cost, location, traffic jams, user preferences). This process is an envelop of multiple services that interact with each other:

- “getAvailableParkingLotsInRange” service: searches the system and returns an array of the available parking lots in the given range (where the parking lot sensors marked as available/unoccupied. 

- “getParkingLotLocation” service: returns an array of the available parking lots locations. This service will called by the “getAvailableParkingLots” service. 

- “getTrafficWeight” returns an array of the traffic weight of the paths leading to each of the available parking lots. This service will called by the “getParkingLotLocation” service. 

- “getSlotRate” returns the cost of the parking slots. This service will be called by the “getAvailableParkingLots” service.
“getLotNeighborhood” This API use a live service on BedeTaxi[5] system, “getInRangeDriver” which services uses openstreetmap[6] to get the names of a will known place nearby a given location, we used this API in order to provide the users a will known and popular location name nearby the slot location.

- “getBestParkingLotsByGA” This API will call a genetic algorithm that well take the data from the previous services and build the genes to get the best barking lots from the available lots in range depending on many mitrics (Cost, location, traffic jams, user preferences).

- “ReserveParkingLot” process:  this process makes a reservation of the parking lot that the user selects, updates the status of the parking lot sensor and deducts from the user’s balance. This process consists of the following services:
“ReserveParkingLot” service  communicates with the server to reserve the selected parking lot (the one that the user selects) and updates the sensor.  It will be implemented as a REST service.
- “GetUserBalance” returns the user’s balance amount available.
“DeductUserBalance” performs the deduction from the user’s account balance. It will be implemented as a REST service.

- “UpdateLotStatus“ process, The lot status could be updated by the sensor when the car lifts its lot, or by the ReserveParkingLot process. It will be implemented as a REST service.
