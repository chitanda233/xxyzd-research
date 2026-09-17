package cn.thinkingdata.analytics.f;

import android.content.SharedPreferences;
import cn.thinkingdata.core.sp.SharedPreferencesStorage;
import java.util.concurrent.Future;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class p extends SharedPreferencesStorage<JSONObject> {
    public p(Future<SharedPreferences> future) {
        super(future, "superProperties");
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public void save(SharedPreferences.Editor editor, JSONObject jSONObject) {
        editor.putString(this.storageKey, jSONObject == null ? null : jSONObject.toString());
        editor.apply();
    }

    /* JADX INFO: Access modifiers changed from: protected */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    public JSONObject create() {
        return new JSONObject();
    }

    /* JADX WARN: Type inference failed for: r0v1, types: [T, org.json.JSONObject] */
    @Override // cn.thinkingdata.core.sp.SharedPreferencesStorage
    protected void load(SharedPreferences sharedPreferences) {
        String string = sharedPreferences.getString(this.storageKey, null);
        if (string == null) {
            put(create());
            return;
        }
        try {
            this.data = new JSONObject(string);
        } catch (JSONException e) {
            e.printStackTrace();
        }
    }
}
