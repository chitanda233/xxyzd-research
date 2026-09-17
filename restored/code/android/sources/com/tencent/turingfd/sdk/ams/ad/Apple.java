package com.tencent.turingfd.sdk.ams.ad;

import android.os.LocaleList;
import java.util.Locale;

/* JADX INFO: loaded from: classes4.dex */
public final class Apple implements Almond {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final LocaleList f3818a;

    public Apple(Object obj) {
        this.f3818a = (LocaleList) obj;
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Almond
    public final Locale get(int i) {
        return this.f3818a.get(i);
    }

    public final int hashCode() {
        return this.f3818a.hashCode();
    }

    @Override // com.tencent.turingfd.sdk.ams.ad.Almond
    public final int size() {
        return this.f3818a.size();
    }
}
