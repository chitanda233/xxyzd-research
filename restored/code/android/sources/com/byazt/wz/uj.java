package com.byazt.wz;

import android.app.Activity;
import android.content.Context;
import com.byazt.aas.nb;
import com.byazt.ete.ic;
import com.byazt.omf.or;
import com.bytedance.sdk.openadsdk.core.activity.base.TTNativePageActivity;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 65, 15})
public abstract class uj implements com.byazt.pop.ve {
    public WeakReference<com.byazt.ua.c.InterfaceC0255c> p;
    public boolean yv = true;

    @Override // com.byazt.pop.ve
    public void c(Activity activity, boolean z) {
    }

    @Override // com.byazt.pop.ve
    public void c(boolean z) {
        this.yv = z;
    }

    @Override // com.byazt.pop.ve
    public void c(com.byazt.ua.c.InterfaceC0255c interfaceC0255c) {
        this.p = new WeakReference<>(interfaceC0255c);
    }

    public boolean c(Context context, ic icVar, String str) {
        if (!this.yv || !com.byazt.aas.n.c(icVar) || !or.c(context, icVar, nb.uj(str), str, x())) {
            return false;
        }
        TTNativePageActivity.c(this);
        return true;
    }

    private String x() {
        com.byazt.ua.c.InterfaceC0255c interfaceC0255c;
        com.byazt.ua.c videoModel;
        WeakReference<com.byazt.ua.c.InterfaceC0255c> weakReference = this.p;
        if (weakReference == null || (interfaceC0255c = weakReference.get()) == null || (videoModel = interfaceC0255c.getVideoModel()) == null) {
            return null;
        }
        return videoModel.c().toString();
    }

    public int gt() {
        return hashCode();
    }
}
