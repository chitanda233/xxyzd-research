package cn.thinkingdata.analytics.f;

import android.content.SharedPreferences;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;
import java.util.concurrent.Future;

/* JADX INFO: loaded from: classes.dex */
public class m extends SharedPreferencesStorage<Boolean> {
    public m(Future<SharedPreferences> future) {
        super(future, "pausePostFlag");
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void save(SharedPreferences.Editor editor, Boolean bool) {
        editor.putBoolean(this.storageKey, bool.booleanValue());
        editor.apply();
    }

    /* JADX WARN: Type inference failed for: r3v2, types: [T, java.lang.Boolean] */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    protected void load(SharedPreferences sharedPreferences) {
        this.data = Boolean.valueOf(sharedPreferences.getBoolean(this.storageKey, false));
    }
}
