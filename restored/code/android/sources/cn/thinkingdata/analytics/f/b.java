package cn.thinkingdata.analytics.f;

import android.content.Context;
import cn.thinkingdata.core.sp.AbstractStoragePlugin;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;

/* JADX INFO: loaded from: classes.dex */
public class b extends AbstractStoragePlugin {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private k f105a;
    private i b;
    private f c;
    private l d;
    private m e;
    private p f;
    private o g;

    public b(Context context, String str) {
        super(context, "com.thinkingdata.analyse_" + str);
    }

    @Override // cn.thinkingdata.core.sp.AbstractStoragePlugin
    protected void createStorage(Context context) {
        this.f105a = new k(this.storedSharedPrefs);
        this.b = new i(this.storedSharedPrefs);
        this.f = new p(this.storedSharedPrefs);
        this.d = new l(this.storedSharedPrefs);
        this.c = new f(this.storedSharedPrefs);
        this.e = new m(this.storedSharedPrefs);
        this.g = new o(this.storedSharedPrefs);
    }

    @Override // cn.thinkingdata.core.sp.AbstractStoragePlugin
    protected <T> SharedPreferencesStorage<T> getSharePreferenceStorage(int i) {
        if (i == 0) {
            return this.c;
        }
        if (i == 3) {
            return this.b;
        }
        if (i == 5) {
            return this.f105a;
        }
        if (i == 6) {
            return this.d;
        }
        if (i == 7) {
            return this.e;
        }
        if (i == 10) {
            return this.f;
        }
        if (i != 11) {
            return null;
        }
        return this.g;
    }
}
