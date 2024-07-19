export default class VehiculeApi {
    static readonly PROVIDER_KEY = 'vehiculeApi';
    readonly host = "https://localhost:7186";

    async getVehicules(): Promise<Vehicle[]> {
        const response = await fetch(this.host + '/Vehicule', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error(`HTTP error! Status: ${response.status}`);
        }

        return await response.json() as Vehicle[];
    }

    async calculate(vehicleType: number, basePrice: number): Promise<Vehicle> {
        const myHeaders = new Headers();
        myHeaders.append("Content-Type", "application/json");

        const raw = JSON.stringify({
            "vehicleType": vehicleType,
            "basePrice": basePrice
        });

        const requestOptions = {
            method: "POST",
            headers: myHeaders,
            body: raw
        };

        const response = await fetch(this.host + "/VehiculeCalculator", requestOptions);

        if (!response.ok) {
            throw new Error(`HTTP error! Status: ${response.status}`);
        }

        return await response.json() as Vehicle;
    }
}