function radar(speed, area) {
    let speedLimit = 0;

    switch (area) {
        case 'motorway': speedLimit = 130; break;
        case 'interstate': speedLimit = 90; break;
        case 'city': speedLimit = 50; break;
        case 'residential': speedLimit = 20; break;
    }

    let difference = speed - speedLimit;
    let status = '';
    if (speed <= speedLimit) {
        console.log(`Driving ${speed} km/h in a ${speedLimit} zone`);
    }
    else if (difference <= 20) {
        status = 'speeding';
        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
    }
    else if (difference > 20 && difference <= 40) {
        status = 'excessive speeding';
        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
    } else {
        status = 'reckless driving';
        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
    }

}

radar(200, 'motorway');