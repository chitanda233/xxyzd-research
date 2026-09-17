package com.kwad.components.core.c;

import android.content.ContentValues;
import android.database.Cursor;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.internal.api.SceneImpl;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.util.List;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class i implements j, Comparable<i> {
    private final String Pk;
    private final String Pu;
    private final String Pv;
    private final String Pw;
    private final long Px;
    private final long createTime;
    private final int ecpm;

    private i(String str, String str2, String str3, int i, String str4, long j, long j2) {
        this.Pu = str;
        this.Pk = str2;
        this.Pv = str3;
        this.ecpm = i;
        this.Pw = str4;
        this.createTime = j;
        this.Px = j2;
    }

    public static List<i> a(e eVar, AdResultData adResultData) {
        List<AdTemplate> proceedTemplateList = adResultData.getProceedTemplateList();
        int size = proceedTemplateList.size();
        long jCurrentTimeMillis = System.currentTimeMillis();
        long jOP = (jCurrentTimeMillis / 1000) + eVar.oP();
        ArrayList arrayList = new ArrayList();
        SceneImpl defaultAdScene = adResultData.getDefaultAdScene();
        Iterator<AdTemplate> it = proceedTemplateList.iterator();
        while (it.hasNext()) {
            AdTemplate next = it.next();
            arrayList.add(new i(String.valueOf(com.kwad.sdk.core.response.helper.e.eW(next)), String.valueOf(adResultData.getPosId()), new AdResultData(adResultData, defaultAdScene, Collections.singletonList(next)).getResponseJson(), com.kwad.sdk.core.response.helper.e.fa(next), adResultData.getDefaultAdScene().toJson().toString(), jCurrentTimeMillis + ((long) size), jOP));
            size--;
            it = it;
            defaultAdScene = defaultAdScene;
        }
        return arrayList;
    }

    public static List<i> a(Cursor cursor) {
        if (cursor == null) {
            return null;
        }
        ArrayList arrayList = new ArrayList();
        while (cursor.moveToNext()) {
            try {
                arrayList.add(c(cursor));
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        }
        return arrayList;
    }

    private static synchronized i c(Cursor cursor) {
        return new i(cursor.getString(cursor.getColumnIndex("creativeId")), cursor.getString(cursor.getColumnIndex("posId")), cursor.getString(cursor.getColumnIndex("adJson")), cursor.getInt(cursor.getColumnIndex("ecpm")), cursor.getString(cursor.getColumnIndex("adSenseJson")), cursor.getLong(cursor.getColumnIndex("createTime")), cursor.getLong(cursor.getColumnIndex("expireTime")));
    }

    public static AdResultData k(List<i> list) {
        ArrayList arrayList = new ArrayList();
        AdResultData adResultDataC = null;
        if (list == null || list.size() == 0) {
            return null;
        }
        Iterator<i> it = list.iterator();
        SceneImpl defaultAdScene = null;
        while (it.hasNext()) {
            adResultDataC = c(it.next());
            if (adResultDataC != null) {
                if (defaultAdScene == null) {
                    defaultAdScene = adResultDataC.getDefaultAdScene();
                }
                arrayList.addAll(adResultDataC.getProceedTemplateList());
            }
        }
        AdResultData adResultData = new AdResultData(adResultDataC, defaultAdScene, arrayList);
        adResultData.setAdSource("cache");
        return adResultData;
    }

    private static AdResultData c(i iVar) {
        if (iVar == null) {
            return null;
        }
        if (iVar.oW() == null || iVar.pa() == null) {
            com.kwad.sdk.core.d.c.w("CachedAd", "createAdResultData cachedAd data illegal");
            return null;
        }
        try {
            String strPa = iVar.pa();
            SceneImpl sceneImpl = new SceneImpl();
            sceneImpl.parseJson(new JSONObject(strPa));
            AdResultData adResultDataCreateFromResponseJson = AdResultData.createFromResponseJson(iVar.oW(), sceneImpl);
            Iterator<AdTemplate> it = adResultDataCreateFromResponseJson.getProceedTemplateList().iterator();
            while (it.hasNext()) {
                it.next().fromCache = true;
            }
            return adResultDataCreateFromResponseJson;
        } catch (JSONException e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
            return null;
        }
    }

    public final String oM() {
        return this.Pk;
    }

    private String oW() {
        return this.Pv;
    }

    private int oX() {
        return this.ecpm;
    }

    private long oY() {
        return this.createTime;
    }

    public final long oZ() {
        return this.Px;
    }

    private String pa() {
        return this.Pw;
    }

    public final String pb() {
        return this.Pu;
    }

    @Override // com.kwad.components.core.c.j
    public final ContentValues oQ() {
        ContentValues contentValues = new ContentValues();
        contentValues.put("creativeId", this.Pu);
        contentValues.put("posId", this.Pk);
        contentValues.put("adJson", this.Pv);
        contentValues.put("ecpm", Integer.valueOf(this.ecpm));
        contentValues.put("adSenseJson", this.Pw);
        contentValues.put("createTime", Long.valueOf(this.createTime));
        contentValues.put("expireTime", Long.valueOf(this.Px));
        contentValues.put("playAgainJson", (String) null);
        return contentValues;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: d, reason: merged with bridge method [inline-methods] */
    public int compareTo(i iVar) {
        if (iVar.oX() == oX()) {
            return (int) (iVar.oY() - oY());
        }
        return iVar.oX() - oX();
    }
}
