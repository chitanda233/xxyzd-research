package com.sigmob.sdk.base.mta;

import android.location.Location;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.mta.DeviceContext;
import com.sigmob.sdk.base.o;

/* JADX INFO: loaded from: classes3.dex */
public class PointFiveEntity extends PointEntitySigmob {
    public String getLat() {
        try {
            if (o.a().P()) {
                return null;
            }
        } catch (Throwable unused) {
        }
        DeviceContext deviceContext = getDeviceContext();
        Location location = deviceContext == null ? ClientMetadata.getInstance().getLocation() : deviceContext.getLocation();
        return location == null ? "0" : String.valueOf(location.getLatitude());
    }

    public String getLng() {
        try {
            if (o.a().P()) {
                return null;
            }
        } catch (Throwable unused) {
        }
        DeviceContext deviceContext = getDeviceContext();
        Location location = deviceContext == null ? ClientMetadata.getInstance().getLocation() : deviceContext.getLocation();
        return location == null ? "0" : String.valueOf(location.getLongitude());
    }
}
