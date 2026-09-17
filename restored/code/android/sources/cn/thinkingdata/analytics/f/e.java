package cn.thinkingdata.analytics.f;

import android.content.Context;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.sp.AbstractStoragePlugin;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;

/* JADX INFO: loaded from: classes.dex */
public class e extends AbstractStoragePlugin {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private k f108a;
    private n b;
    private j c;

    public e(Context context) {
        super(context, "com.thinkingdata.analyse");
    }

    @Override // cn.thinkingdata.core.sp.AbstractStoragePlugin
    protected void createStorage(Context context) {
        this.b = new n(this.storedSharedPrefs);
        this.f108a = new k(this.storedSharedPrefs);
        this.c = new j(q.b(context), this.storedSharedPrefs);
    }

    @Override // cn.thinkingdata.core.sp.AbstractStoragePlugin
    protected <T> SharedPreferencesStorage<T> getSharePreferenceStorage(int i) {
        if (i == 4) {
            return this.c;
        }
        if (i == 5) {
            return this.f108a;
        }
        if (i != 9) {
            return null;
        }
        return this.b;
    }
}
