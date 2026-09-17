package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.res.Resources;
import android.os.Build;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Bagasse {
    public static Virgo a(Context context) {
        Virgo virgo = Virgo.b;
        if (Build.VERSION.SDK_INT < 33) {
            return Arbutus.a(Resources.getSystem().getConfiguration());
        }
        Object systemService = context.getSystemService("locale");
        return systemService != null ? new Virgo(new Apple(Avocado.a(systemService))) : virgo;
    }
}
