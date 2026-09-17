package com.sigmob.sdk.base.services;

import android.location.Criteria;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Bundle;
import com.bykv.vk.component.ttvideo.ILivePlayer;
import com.czhj.sdk.common.ClientMetadata;
import com.sigmob.sdk.base.utils.k;
import com.sigmob.sdk.base.utils.v;

/* JADX INFO: loaded from: classes3.dex */
public class e implements f.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3247a = "e";
    private static volatile LocationManager c;
    private g e = g.STOP;
    private static final LocationListener b = new LocationListener() { // from class: com.sigmob.sdk.base.services.e.1
        @Override // android.location.LocationListener
        public void onLocationChanged(Location location) {
            k.c(e.f3247a, "onLocationChanged: location = " + location.toString(), new Object[0]);
            ClientMetadata clientMetadata = ClientMetadata.getInstance();
            if (v.b(clientMetadata)) {
                clientMetadata.setLocation(location);
            }
        }

        @Override // android.location.LocationListener
        public void onProviderDisabled(String provider) {
        }

        @Override // android.location.LocationListener
        public void onProviderEnabled(String provider) {
        }

        @Override // android.location.LocationListener
        public void onStatusChanged(String provider, int status, Bundle extras) {
        }
    };
    private static String d = "network";

    e() {
        LocationManager locationManagerA;
        if (ClientMetadata.getInstance() == null || (locationManagerA = a()) == null) {
            return;
        }
        Criteria criteria = new Criteria();
        criteria.setAccuracy(2);
        criteria.setAltitudeRequired(false);
        criteria.setBearingRequired(false);
        criteria.setCostAllowed(false);
        criteria.setPowerRequirement(1);
        d = locationManagerA.getBestProvider(criteria, false);
    }

    static LocationManager a() {
        if (c == null) {
            synchronized (e.class) {
                if (c == null) {
                    c = ClientMetadata.getInstance().getLocationManager();
                }
            }
        }
        return c;
    }

    private void c() {
        try {
            if (v.b(c)) {
                c.removeUpdates(b);
            }
            c = null;
        } catch (Throwable th) {
            k.f(f3247a, "stopUpdateLocation: error = " + th.getMessage(), new Object[0]);
        }
    }

    private void d() {
        String str;
        try {
            LocationManager locationManagerA = a();
            if (locationManagerA == null || (str = d) == null || !locationManagerA.isProviderEnabled(str)) {
                return;
            }
            k.c(f3247a, "startUpdateLocation", new Object[0]);
            locationManagerA.requestLocationUpdates(d, ILivePlayer.RETRY_TIME_INTERVAL_DEFAULT, 500.0f, b);
            this.e = g.RUNNING;
        } catch (Throwable th) {
            k.f(f3247a, "startUpdateLocation: error = " + th.getMessage(), new Object[0]);
        }
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public boolean e() {
        if (this.e == g.RUNNING) {
            return false;
        }
        d();
        return true;
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public g f() {
        return this.e;
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public void g() {
        if (this.e == g.RUNNING) {
            c();
            this.e = g.STOP;
        }
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public Error h() {
        return null;
    }
}
