package com.sigmob.sdk.videoAd;

import android.app.Activity;
import android.content.Context;
import android.os.Build;
import android.os.Bundle;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.n;

/* JADX INFO: loaded from: classes4.dex */
public abstract class b extends com.sigmob.sdk.base.common.j {
    protected b(Activity activity, String uuid, com.sigmob.sdk.base.common.k listener) {
        super(activity, uuid, listener);
    }

    protected void a(boolean shouldFinish) {
        if (shouldFinish) {
            this.d.a();
        }
    }

    protected void b(Context context, int orientation, Bundle intentExtras) {
        try {
            a(context.getApplicationContext(), orientation, intentExtras);
            boolean z = intentExtras.getBoolean(n.v, false);
            boolean z2 = intentExtras.getBoolean(n.u, false);
            if (Build.VERSION.SDK_INT >= 27) {
                if (z) {
                    n().setTurnScreenOn(true);
                }
                if (z2) {
                    n().setShowWhenLocked(true);
                    n().setTurnScreenOn(true);
                }
            }
            if (z) {
                n().getWindow().addFlags(128);
            }
            if (z2) {
                n().getWindow().addFlags(2621440);
            }
        } catch (Throwable th) {
            SigmobLog.e("optionSetting error", th);
        }
    }

    @Override // com.sigmob.sdk.base.common.j
    public void e() {
        this.d.onSetContentView(this.c);
    }
}
