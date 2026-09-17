package com.byazt.tv;

import android.content.ContentValues;
import android.database.Cursor;
import android.text.TextUtils;
import androidx.core.app.NotificationCompat;
import com.sigmob.sdk.base.mta.PointParamKey;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 239, 54})
public class ve extends c {
    public long m;
    public long nu;
    public String t;
    public String u;
    public String yp;
    public String z;

    @Override // com.byazt.tv.c
    public String uj() {
        return NotificationCompat.CATEGORY_EVENT;
    }

    @Override // com.byazt.tv.c
    public List<String> c() {
        List<String> listC = super.c();
        ArrayList arrayList = new ArrayList(listC.size());
        arrayList.addAll(listC);
        arrayList.addAll(Arrays.asList(PointParamKey.CATEGORY, "varchar", "tag", "varchar", "value", "integer", "ext_value", "integer", "params", "varchar", "label", "varchar"));
        return arrayList;
    }

    @Override // com.byazt.tv.c
    public int c(Cursor cursor) {
        int iC = super.c(cursor);
        int i = iC + 1;
        this.t = cursor.getString(iC);
        int i2 = i + 1;
        this.u = cursor.getString(i);
        int i3 = i2 + 1;
        this.m = cursor.getLong(i2);
        int i4 = i3 + 1;
        this.nu = cursor.getLong(i3);
        int i5 = i4 + 1;
        this.z = cursor.getString(i4);
        int i6 = i5 + 1;
        this.yp = cursor.getString(i5);
        return i6;
    }

    @Override // com.byazt.tv.c
    public void c(ContentValues contentValues) {
        super.c(contentValues);
        contentValues.put(PointParamKey.CATEGORY, this.t);
        contentValues.put("tag", this.u);
        contentValues.put("value", Long.valueOf(this.m));
        contentValues.put("ext_value", Long.valueOf(this.nu));
        contentValues.put("params", this.z);
        contentValues.put("label", this.yp);
    }

    @Override // com.byazt.tv.c
    public void c(JSONObject jSONObject) throws JSONException {
        super.c(jSONObject);
        jSONObject.put("tea_event_index", this.ve);
        jSONObject.put(PointParamKey.CATEGORY, this.t);
        jSONObject.put("tag", this.u);
        jSONObject.put("value", this.m);
        jSONObject.put("ext_value", this.nu);
        jSONObject.put("params", this.z);
        jSONObject.put("label", this.yp);
    }

    @Override // com.byazt.tv.c
    public c tt(JSONObject jSONObject) {
        super.tt(jSONObject);
        this.ve = jSONObject.optLong("tea_event_index", 0L);
        this.t = jSONObject.optString(PointParamKey.CATEGORY, null);
        this.u = jSONObject.optString("tag", null);
        this.m = jSONObject.optLong("value", 0L);
        this.nu = jSONObject.optLong("ext_value", 0L);
        this.z = jSONObject.optString("params", null);
        this.yp = jSONObject.optString("label", null);
        return this;
    }

    @Override // com.byazt.tv.c
    public JSONObject tt() throws JSONException {
        JSONObject jSONObject = !TextUtils.isEmpty(this.z) ? new JSONObject(this.z) : null;
        if (jSONObject == null) {
            jSONObject = new JSONObject();
        }
        jSONObject.put("local_time_ms", this.tt);
        jSONObject.put("tea_event_index", this.ve);
        jSONObject.put("session_id", this.uj);
        if (this.n > 0) {
            jSONObject.put("user_id", this.n);
        }
        jSONObject.put("user_unique_id", TextUtils.isEmpty(this.f1452a) ? JSONObject.NULL : this.f1452a);
        if (!TextUtils.isEmpty(this.sp)) {
            jSONObject.put("ssid", this.sp);
        }
        jSONObject.put(PointParamKey.CATEGORY, this.t);
        jSONObject.put("tag", this.u);
        jSONObject.put("value", this.m);
        jSONObject.put("ext_value", this.nu);
        jSONObject.put("label", this.yp);
        jSONObject.put("datetime", this.sl);
        if (!TextUtils.isEmpty(this.x)) {
            jSONObject.put("ab_sdk_version", this.x);
        }
        return jSONObject;
    }

    @Override // com.byazt.tv.c
    public String x() {
        return this.u + ", " + this.yp;
    }

    @Override // com.byazt.tv.c
    public String i() {
        return this.z;
    }
}
