package com.kwad.components.core.t;

import android.content.Context;
import android.location.LocationManager;
import androidx.core.content.ContextCompat;

/* JADX INFO: loaded from: classes3.dex */
public final class o {
    public static boolean aO(Context context) {
        try {
            LocationManager locationManager = (LocationManager) context.getSystemService("location");
            return locationManager != null && locationManager.isProviderEnabled("gps");
        } catch (Exception unused) {
        }
    }

    private static boolean aP(Context context) {
        try {
            return ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.g) == 0 || ContextCompat.checkSelfPermission(context, com.kuaishou.weapon.p0.g.h) == 0;
        } catch (Exception unused) {
            return false;
        }
    }
}
