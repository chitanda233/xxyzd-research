package com.tencent.turingfd.sdk.ams.ad;

import java.util.Locale;

/* JADX INFO: loaded from: classes4.dex */
public final class Virgo {
    public static final Virgo b = new Virgo(new Apple(UrsaMinor.a(new Locale[0])));

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Almond f3903a;

    public Virgo(Almond almond) {
        this.f3903a = almond;
    }

    public static Virgo a(String str) {
        if (str == null || str.isEmpty()) {
            return b;
        }
        String[] strArrSplit = str.split(",", -1);
        int length = strArrSplit.length;
        Locale[] localeArr = new Locale[length];
        for (int i = 0; i < length; i++) {
            localeArr[i] = UrsaMajor.a(strArrSplit[i]);
        }
        return new Virgo(new Apple(UrsaMinor.a(localeArr)));
    }
}
