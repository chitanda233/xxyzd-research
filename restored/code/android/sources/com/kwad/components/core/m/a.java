package com.kwad.components.core.m;

import com.kwad.sdk.core.d.c;
import java.text.SimpleDateFormat;
import java.util.Date;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.sdk.core.response.a.a implements com.kwad.sdk.core.b {
    private static SimpleDateFormat abp = new SimpleDateFormat("yyyy-MM-dd");
    public int abq;
    public long abr;

    public final boolean l(int i, int i2) {
        c.d("AdForceActiveInfo", "checkAndAddCount forceActiveIntervalHour: " + i + ", forceActiveThreshold: " + i2);
        if (this.abr > 0) {
            long jCurrentTimeMillis = System.currentTimeMillis();
            String str = abp.format(new Date(this.abr));
            String str2 = abp.format(new Date(jCurrentTimeMillis));
            c.d("AdForceActiveInfo", "checkAndAddCount lastDate: " + str + ", currentDate: " + str2);
            if (!str.equals(str2)) {
                this.abq = 0;
                tA();
                return true;
            }
            long j = this.abr + (((long) i) * 60 * 60 * 1000);
            c.d("AdForceActiveInfo", "checkAndAddCount minTimestamp: " + j + ", currentActiveCount: " + this.abq);
            if (j >= jCurrentTimeMillis || this.abq > i2) {
                return false;
            }
            tA();
            return true;
        }
        tA();
        return true;
    }

    public final void tA() {
        this.abr = System.currentTimeMillis();
        this.abq++;
        c.d("AdForceActiveInfo", "doAddCount, lastForceActiveTimestamp: " + this.abr + ", currentActiveCount " + this.abq);
    }
}
