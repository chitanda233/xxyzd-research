package cn.thinkingdata.analytics.f;

import android.content.SharedPreferences;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;
import java.util.concurrent.Future;

/* JADX INFO: loaded from: classes.dex */
public class h extends SharedPreferencesStorage<Integer> {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final int f110a;

    public h(Future<SharedPreferences> future, int i) {
        super(future, "flushInterval");
        this.f110a = i;
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void save(SharedPreferences.Editor editor, Integer num) {
        editor.putInt(this.storageKey, num.intValue());
        editor.apply();
    }

    /* JADX WARN: Type inference failed for: r3v2, types: [T, java.lang.Integer] */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    protected void load(SharedPreferences sharedPreferences) {
        this.data = Integer.valueOf(sharedPreferences.getInt(this.storageKey, this.f110a));
    }
}
