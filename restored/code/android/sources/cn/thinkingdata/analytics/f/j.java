package cn.thinkingdata.analytics.f;

import android.content.SharedPreferences;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;
import java.util.concurrent.Future;

/* JADX INFO: loaded from: classes.dex */
public class j extends SharedPreferencesStorage<Long> {
    public j(String str, Future<SharedPreferences> future) {
        super(future, str + "_lastInstallTime");
    }

    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void save(SharedPreferences.Editor editor, Long l) {
        editor.putLong(this.storageKey, l.longValue());
        editor.apply();
    }

    /* JADX WARN: Can't rename method to resolve collision */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    public Long create() {
        return 0L;
    }

    /* JADX WARN: Type inference failed for: r4v1, types: [T, java.lang.Long] */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    public void load(SharedPreferences sharedPreferences) {
        this.data = Long.valueOf(sharedPreferences.getLong(this.storageKey, 0L));
    }
}
