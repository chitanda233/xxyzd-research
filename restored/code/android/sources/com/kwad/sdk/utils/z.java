package com.kwad.sdk.utils;

import android.content.Context;
import android.location.Location;
import android.location.LocationManager;
import androidx.core.content.ContextCompat;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class z {
    private static boolean bpd;
    private static com.kwad.sdk.utils.c.a bpe = new com.kwad.sdk.utils.c.a();

    public static com.kwad.sdk.utils.c.a df(Context context) {
        com.kwad.sdk.utils.c.a aVar;
        com.kwad.sdk.internal.api.a aVarWo;
        com.kwad.sdk.utils.c.a aVar2 = new com.kwad.sdk.utils.c.a();
        if (be.readLocationDisable() && (aVarWo = be.Wo()) != null) {
            aVar2.bsJ = aVarWo;
            aVar2.type = 1;
            return aVar2;
        }
        if (bpd || (((aVar = bpe) != null && aVar.bsJ != null) || context == null)) {
            return bpe;
        }
        if (!be.readLocationDisable() && !((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).al(64L)) {
            try {
                LocationManager locationManager = (LocationManager) context.getSystemService("location");
                if (locationManager.isProviderEnabled("gps")) {
                    bpe.bsJ = a(context, locationManager);
                }
                if (bpe == null && locationManager.isProviderEnabled("network")) {
                    bpe.bsJ = b(context, locationManager);
                }
                if (bpe == null && locationManager.isProviderEnabled("passive")) {
                    bpe.bsJ = c(context, locationManager);
                }
                bpe.type = 0;
                return bpe;
            } catch (Exception e) {
                bpd = true;
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            }
        }
        return null;
    }

    private static com.kwad.sdk.internal.api.a a(Context context, LocationManager locationManager) {
        try {
            if (ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.g) != 0) {
                return null;
            }
            Location lastKnownLocation = locationManager.getLastKnownLocation("gps");
            if (lastKnownLocation == null) {
                bpd = true;
            }
            return com.kwad.sdk.internal.api.a.a(lastKnownLocation);
        } catch (Exception e) {
            bpd = true;
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    private static com.kwad.sdk.internal.api.a b(Context context, LocationManager locationManager) {
        try {
            if (ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.g) != 0 && ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.h) != 0) {
                return null;
            }
            Location lastKnownLocation = locationManager.getLastKnownLocation("network");
            if (lastKnownLocation == null) {
                bpd = true;
            }
            return com.kwad.sdk.internal.api.a.a(lastKnownLocation);
        } catch (Exception e) {
            bpd = true;
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    private static com.kwad.sdk.internal.api.a c(Context context, LocationManager locationManager) {
        try {
            if (ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.h) != 0) {
                return null;
            }
            Location lastKnownLocation = locationManager.getLastKnownLocation("passive");
            if (lastKnownLocation == null) {
                bpd = true;
            }
            return com.kwad.sdk.internal.api.a.a(lastKnownLocation);
        } catch (Exception e) {
            bpd = true;
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }
}
