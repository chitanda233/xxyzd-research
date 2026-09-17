package com.kwad.components.ad.fullscreen.b;

import com.kwad.sdk.core.d.c;
import java.text.SimpleDateFormat;
import java.util.Date;

/* JADX INFO: loaded from: classes3.dex */
public class b extends com.kwad.sdk.core.response.a.a {
    private static SimpleDateFormat jU = new SimpleDateFormat("yyyy-MM-dd");
    public long jV;
    public int jW;

    public b() {
        this.jV = -1L;
        this.jW = -1;
    }

    public b(long j, int i) {
        this.jV = j;
        this.jW = 1;
    }

    public final boolean j(long j) {
        if (this.jV > 0 && j > 0) {
            try {
                return jU.format(new Date(this.jV)).equals(jU.format(new Date(j)));
            } catch (Exception e) {
                c.printStackTraceOnly(e);
            }
        }
        return false;
    }

    public final boolean F(int i) {
        int i2 = this.jW;
        return i2 > 0 && i2 >= i;
    }
}
