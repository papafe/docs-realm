// swiftlint:disable identifier_name

import XCTest
// :snippet-start: import-realm
import RealmSwift
// :snippet-end:

let YOUR_APP_SERVICES_APP_ID = "example-testers-kvjdy"

// :snippet-start: init-realm-app-client
let app = App(id: YOUR_APP_SERVICES_APP_ID) // replace YOUR_APP_SERVICES_APP_ID with your App ID
// :snippet-end:

class RealmAppTest: XCTestCase {
    func testRealmAppWithConfig() {
        // :snippet-start: realm-app-config
        let configuration = AppConfiguration(
           baseURL: "https://realm.mongodb.com", // Custom base URL
           transport: nil, // Custom RLMNetworkTransportProtocol
           localAppName: "My App",
           localAppVersion: "3.14.159",
           defaultRequestTimeoutMS: 30000
        )

        let app = App(id: "my-app-services-app-id", configuration: configuration)
        // :snippet-end:
        print(app)
    }
}
