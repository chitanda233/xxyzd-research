package com.tencent.turingfd.sdk.ams.ad;

import android.app.LocaleManager;
import android.os.LocaleList;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Avocado {
    public static LocaleList a(Object obj) {
        return ((LocaleManager) obj).getSystemLocales();
    }
}
