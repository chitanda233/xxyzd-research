package com.tencent.turingfd.sdk.ams.ad;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.Locale;

/* JADX INFO: loaded from: classes4.dex */
public final class Vulpecula implements Almond {
    public static final Locale[] b = new Locale[0];

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final Locale[] f3904a;

    public Vulpecula(Locale... localeArr) {
        if (localeArr.length == 0) {
            this.f3904a = b;
            return;
        }
        ArrayList arrayList = new ArrayList();
        HashSet hashSet = new HashSet();
        for (int i = 0; i < localeArr.length; i++) {
            Locale locale = localeArr[i];
            if (locale == null) {
                throw new NullPointerException("list[" + i + "] is null");
            }
            if (!hashSet.contains(locale)) {
                Locale locale2 = (Locale) locale.clone();
                arrayList.add(locale2);
                locale2.getLanguage();
                String country = locale2.getCountry();
                if (country != null && !country.isEmpty()) {
                    locale2.getCountry();
                }
                hashSet.add(locale2);
            }
        }
        this.f3904a = (Locale[]) arrayList.toArray(new Locale[0]);
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Almond
    public final Locale get(int i) {
        if (i < 0) {
            return null;
        }
        Locale[] localeArr = this.f3904a;
        if (i < localeArr.length) {
            return localeArr[i];
        }
        return null;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Almond
    public final int size() {
        return this.f3904a.length;
    }
}
