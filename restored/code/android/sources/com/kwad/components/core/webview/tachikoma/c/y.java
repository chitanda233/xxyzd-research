package com.kwad.components.core.webview.tachikoma.c;

import android.text.TextUtils;
import com.sigmob.sdk.base.mta.PointCategory;

/* JADX INFO: loaded from: classes3.dex */
public class y extends com.kwad.sdk.core.response.a.a {
    public String auC;
    public int errorCode;
    public String errorReason;
    public int ri;

    public final boolean zD() {
        return TextUtils.equals("start", this.auC);
    }

    public final boolean zE() {
        return TextUtils.equals(PointCategory.END, this.auC);
    }

    public final boolean isFailed() {
        return TextUtils.equals(com.alipay.sdk.m.y.k.j, this.auC);
    }

    public final boolean zF() {
        return TextUtils.equals("progress", this.auC);
    }

    public final boolean zG() {
        return TextUtils.equals(com.sigmob.sdk.base.common.a.j, this.auC);
    }

    public final boolean zH() {
        return TextUtils.equals("resume", this.auC);
    }

    public final int zI() {
        try {
            return (int) Long.parseLong(this.errorReason);
        } catch (NumberFormatException e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            return 0;
        }
    }
}
