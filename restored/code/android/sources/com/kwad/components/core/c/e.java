package com.kwad.components.core.c;

import android.content.ContentValues;
import android.database.Cursor;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class e implements j {
    private static volatile e Pj;
    private String Pk;
    private int Pl = 0;
    private int cacheSize = 1;
    private long Pm = 1800;
    private boolean enable = false;

    public static e ax(AdTemplate adTemplate) {
        if (adTemplate == null) {
            return null;
        }
        long j = adTemplate.posId;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        e eVar = new e(j);
        eVar.Pl = adInfoEM.adBaseInfo.adCacheStrategy;
        eVar.Pm = adInfoEM.adBaseInfo.adCacheSecond;
        eVar.cacheSize = adInfoEM.adBaseInfo.adCacheSize;
        eVar.enable = adInfoEM.adBaseInfo.adCacheSwitch == 1;
        return eVar;
    }

    public static synchronized List<e> a(Cursor cursor) {
        if (cursor == null) {
            return null;
        }
        ArrayList arrayList = new ArrayList();
        while (cursor.moveToNext()) {
            try {
                arrayList.add(b(cursor));
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        }
        return arrayList;
    }

    private static synchronized e b(Cursor cursor) {
        e eVar;
        String string = cursor.getString(cursor.getColumnIndex("posId"));
        int i = cursor.getInt(cursor.getColumnIndex("strategyCode"));
        int i2 = cursor.getInt(cursor.getColumnIndex("cacheSize"));
        long j = cursor.getLong(cursor.getColumnIndex("cacheSecond"));
        boolean z = true;
        if (cursor.getInt(cursor.getColumnIndex("enable")) != 1) {
            z = false;
        }
        eVar = new e();
        eVar.Pk = string;
        eVar.Pl = i;
        eVar.cacheSize = i2;
        eVar.Pm = j;
        eVar.enable = z;
        return eVar;
    }

    private static e oL() {
        if (Pj == null) {
            synchronized (e.class) {
                if (Pj == null) {
                    Pj = new e();
                }
            }
        }
        return Pj;
    }

    public static e x(long j) {
        e eVarAf;
        return (a.oF() == null || (eVarAf = a.oF().af(String.valueOf(j))) == null) ? oL() : eVarAf;
    }

    private e() {
    }

    private e(long j) {
        this.Pk = String.valueOf(j);
    }

    public final String oM() {
        return this.Pk;
    }

    public final int oN() {
        return this.Pl;
    }

    public final int oO() {
        return this.cacheSize;
    }

    public final long oP() {
        return this.Pm;
    }

    public final boolean isEnable() {
        return this.enable;
    }

    public final boolean isDefault() {
        return equals(oL());
    }

    @Override // com.kwad.components.core.c.j
    public final ContentValues oQ() {
        ContentValues contentValues = new ContentValues();
        contentValues.put("posId", this.Pk);
        contentValues.put("strategyCode", Integer.valueOf(this.Pl));
        contentValues.put("cacheSize", Integer.valueOf(this.cacheSize));
        contentValues.put("cacheSecond", Long.valueOf(this.Pm));
        contentValues.put("enable", Integer.valueOf(this.enable ? 1 : 0));
        return contentValues;
    }
}
