document.addEventListener("DOMContentLoaded", function (event) {

    // user input

    const countrySelect = document.getElementById('countrySelect');

    const citySelect = document.getElementById('citySelect');

    const weatherLocationValue = document.getElementById('weatherLocation');
    const weatherTimeValue = document.getElementById('weatherTime');
    const weatherDewPointValue = document.getElementById('weatherDewPoint');
    const weatherPressureValue = document.getElementById('weatherPressure');
    const weatherRelativeHumidityValue = document.getElementById('weatherRelativeHumidity');
    const weatherSkyConditionsValue = document.getElementById('weatherSkyConditions');
    const weatherTemperatureValue = document.getElementById('weatherTemperature');
    const weatherVisibilityValue = document.getElementById('weatherVisibility');
    const weatherWindValue = document.getElementById('weatherWind');

    // get countries

    const fetchOptions = {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        redirect: 'follow',
    };

    fetch('/api/countries/get-many', fetchOptions)
        .then(response => {

            if (!response.ok) {
                throw `${response.status} ${response.statusText}`;
            }

            response.json()
                .then(responsePayload => {

                    responsePayload.forEach(country => {

                        const option = document.createElement('option');
                        option.setAttribute('value', country.id);
                        option.innerText = country.name;

                        countrySelect.appendChild(option);
                    });

                })
                .catch(error => {
                    console.log(`json error: ${error}`);
                    return;
                });
        })
        .catch(error => {
            console.log(`fetch error: ${error}`);
            return;
        })


    // country changed event
    countrySelect.addEventListener('change', event => {

        // clear existing cities first
        for (var a = citySelect.options.length - 1; a >= 1; a--) {
            citySelect.remove(a);
        }

        resetWeather();


        // get cities by country id

        const selectedCountryId = countrySelect.options[countrySelect.selectedIndex].value;

        if (selectedCountryId == '') {
            return;
        }

        const fetchOptions = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            redirect: 'follow',
        };

        fetch(`/api/cities/get-many?countryId=${selectedCountryId}`, fetchOptions)
            .then(response => {

                if (!response.ok) {
                    throw `${response.status} ${response.statusText}`;
                }

                response.json()
                    .then(responsePayload => {

                        responsePayload.forEach(city => {

                            const option = document.createElement('option');
                            option.setAttribute('value', city.id);
                            option.innerText = city.name;

                            citySelect.appendChild(option);
                        });
                    })
                    .catch(error => {
                        console.log(`json error: ${error}`);
                        return;
                    });
            })
            .catch(error => {
                console.log(`fetch error: ${error}`);
                return;
            });
    });


    // city changed event
    citySelect.addEventListener('change', event => {

        resetWeather();


        // get weather by city id

        const selectedCityId = citySelect.options[citySelect.selectedIndex].value;

        if (selectedCityId == '') {
            return;
        }

        const fetchOptions = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            redirect: 'follow',
        };

        fetch(`/api/weathers/get-single?cityId=${selectedCityId}`, fetchOptions)
            .then(response => {

                if (!response.ok) {
                    throw `${response.status} ${response.statusText}`;
                }

                response.json()
                    .then(responsePayload => {

                        weatherLocationValue.innerText = responsePayload.location;
                        weatherTimeValue.innerText = responsePayload.time;
                        weatherDewPointValue.innerText = responsePayload.dewPoint;
                        weatherPressureValue.innerText = responsePayload.pressure;
                        weatherRelativeHumidityValue.innerText = responsePayload.relativeHumidity;
                        weatherSkyConditionsValue.innerText = responsePayload.skyConditions;
                        weatherTemperatureValue.innerText = responsePayload.temperature;
                        weatherVisibilityValue.innerText = responsePayload.visibility;
                        weatherWindValue.innerText = responsePayload.wind;
                    })
                    .catch(error => {
                        console.log(`json error: ${error}`);
                        return;
                    });
            })
            .catch(error => {
                console.log(`fetch error: ${error}`);
                return;
            });
    });

    function resetWeather() {

        weatherLocationValue.innerText = '';
        weatherTimeValue.innerText = '';
        weatherDewPointValue.innerText = '';
        weatherPressureValue.innerText = '';
        weatherRelativeHumidityValue.innerText = '';
        weatherSkyConditionsValue.innerText = '';
        weatherTemperatureValue.innerText = '';
        weatherVisibilityValue.innerText = '';
        weatherWindValue.innerText = '';
    }
});
