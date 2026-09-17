package com.tencent.turingfd.sdk.ams.ad;

import android.location.Location;
import android.location.LocationListener;
import android.os.Bundle;

/* JADX INFO: loaded from: classes4.dex */
public final class Bergamot implements LocationListener {
    public static final Banana f = new Banana();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Bennet[] f3823a = new Bennet[3];
    public volatile int b = 0;
    public final Bennet c = new Bennet();
    public volatile boolean d = false;
    public volatile boolean e = false;

    public final String a() {
        String str;
        if (!this.d) {
            return null;
        }
        synchronized (this.c) {
            long j = this.c.f3822a;
            String strValueOf = j > 0 ? String.valueOf(j) : "";
            String strA = Teazle.a(this.c.c);
            String strA2 = Teazle.a(this.c.d);
            Double d = this.c.e;
            String strA3 = d != null ? Teazle.a(d.doubleValue()) : "";
            Float f2 = this.c.f;
            String strA4 = f2 != null ? Teazle.a(f2.floatValue()) : "";
            Float f3 = this.c.g;
            String strA5 = f3 != null ? Teazle.a(f3.floatValue()) : "";
            Float f4 = this.c.h;
            String strA6 = f4 != null ? Teazle.a(f4.floatValue()) : "";
            Float f5 = this.c.i;
            String strA7 = f5 != null ? Teazle.a(f5.floatValue()) : "";
            String str2 = this.c.b;
            if (str2 == null) {
                str2 = "";
            }
            str = strValueOf + "," + strA + "," + strA2 + "," + strA3 + "," + strA4 + "," + strA5 + "," + strA6 + "," + strA7 + "," + str2;
        }
        return str;
    }

    public final String b() {
        StringBuilder sb = new StringBuilder();
        synchronized (this.f3823a) {
            int length = this.b;
            do {
                Bennet bennet = this.f3823a[length];
                if (bennet == null) {
                    break;
                }
                if (sb.length() > 0) {
                    sb.append(",");
                }
                sb.append(bennet.f3822a).append(":").append(bennet.b);
                length--;
                if (length < 0) {
                    length = this.f3823a.length - 1;
                }
            } while (length != this.b);
        }
        if (sb.length() > 0) {
            return sb.toString();
        }
        return null;
    }

    @Override // android.location.LocationListener
    public final void onLocationChanged(Location location) {
        if (location == null) {
            return;
        }
        synchronized (this.c) {
            this.c.f3822a = System.currentTimeMillis();
            if (this.e) {
                this.c.b = location.getProvider();
                this.c.c = location.getLatitude();
                this.c.d = location.getLongitude();
                this.c.e = location.hasAltitude() ? Double.valueOf(location.getAltitude()) : null;
                this.c.f = location.hasAccuracy() ? Float.valueOf(location.getAccuracy()) : null;
                this.c.g = location.hasVerticalAccuracy() ? Float.valueOf(location.getVerticalAccuracyMeters()) : null;
                this.c.h = location.hasBearing() ? Float.valueOf(location.getBearing()) : null;
                this.c.i = location.hasSpeed() ? Float.valueOf(location.getSpeed()) : null;
                this.d = true;
            }
        }
        if (location.isFromMockProvider()) {
            synchronized (this.c) {
                synchronized (this.f3823a) {
                    Bennet bennet = this.f3823a[this.b];
                    if (bennet == null) {
                        bennet = new Bennet();
                        this.f3823a[this.b] = bennet;
                    }
                    this.b = (this.b + 1) % this.f3823a.length;
                    bennet.f3822a = this.c.f3822a;
                    if (this.d) {
                        Bennet bennet2 = this.c;
                        bennet.b = bennet2.b;
                        bennet.c = bennet2.c;
                        bennet.d = bennet2.d;
                        bennet.e = bennet2.e;
                        bennet.f = bennet2.f;
                        bennet.g = bennet2.g;
                        bennet.h = bennet2.h;
                        bennet.i = bennet2.i;
                    }
                }
            }
        }
    }

    @Override // android.location.LocationListener
    public final void onProviderDisabled(String str) {
    }

    @Override // android.location.LocationListener
    public final void onProviderEnabled(String str) {
    }

    @Override // android.location.LocationListener
    public final void onStatusChanged(String str, int i, Bundle bundle) {
    }
}
