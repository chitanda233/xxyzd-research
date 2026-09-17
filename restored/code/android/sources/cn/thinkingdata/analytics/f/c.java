package cn.thinkingdata.analytics.f;

import android.content.Context;
import cn.thinkingdata.core.sp.AbstractStoragePlugin;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;

/* JADX INFO: loaded from: classes.dex */
public class c extends AbstractStoragePlugin {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private h f106a;
    private g b;

    public c(Context context, String str) {
        super(context, "cn.thinkingdata.android.config_" + str);
    }

    @Override // cn.thinkingdata.core.sp.AbstractStoragePlugin
    protected void createStorage(Context context) {
        this.f106a = new h(this.storedSharedPrefs, 15000);
        this.b = new g(this.storedSharedPrefs, 20);
    }

    @Override // cn.thinkingdata.core.sp.AbstractStoragePlugin
    protected <T> SharedPreferencesStorage<T> getSharePreferenceStorage(int i) {
        if (i == 1) {
            return this.b;
        }
        if (i != 2) {
            return null;
        }
        return this.f106a;
    }
}
