package com.qq.gdt.action;

import android.content.ContentProvider;
import android.content.ContentValues;
import android.database.Cursor;
import android.net.Uri;
import android.os.Bundle;
import com.qq.gdt.action.i.g;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.s;

/* JADX INFO: loaded from: classes3.dex */
public class GDTInitProvider extends ContentProvider {
    /* JADX WARN: Code duplicated, block: B:14:0x0067  */
    @Override // android.content.ContentProvider
    public Bundle call(String str, String str2, Bundle bundle) {
        byte b;
        o.a("get  method : " + str + ", arg: " + str2 + " , bundle: " + bundle.toString(), new Object[0]);
        bundle.setClassLoader(getClass().getClassLoader());
        final Bundle bundle2 = new Bundle();
        try {
            int iHashCode = str.hashCode();
            if (iHashCode != -606299040) {
                if (iHashCode == 854044409 && str.equals("get_user_info")) {
                    b = 1;
                } else {
                    b = -1;
                }
            } else if (str.equals("save_user_info")) {
                b = 0;
            } else {
                b = -1;
            }
            if (b == 0) {
                com.qq.gdt.action.multioprocess.b bVar = (com.qq.gdt.action.multioprocess.b) bundle.getSerializable("user_message_info");
                o.a("cp save userMessage " + bVar, new Object[0]);
                if (bVar == null) {
                    com.qq.gdt.action.g.a.a(3303);
                    o.a("save null，end", new Object[0]);
                } else {
                    com.qq.gdt.action.multioprocess.d.a().f3099a = bVar;
                    s.a(bVar);
                    o.a("cp save end", new Object[0]);
                }
            } else if (b != 1) {
                com.qq.gdt.action.g.a.a(3302);
                o.a("cp not match method ", new Object[0]);
            } else {
                com.qq.gdt.action.multioprocess.b bVar2 = com.qq.gdt.action.multioprocess.d.a().f3099a;
                o.a("cp process get UserMessage = " + bVar2, new Object[0]);
                if (bVar2 != null) {
                    o.a("cp memory UserMessage not null", new Object[0]);
                    bundle2.putSerializable("result_user_info", bVar2);
                } else {
                    s.a(new com.qq.gdt.action.multioprocess.c() { // from class: com.qq.gdt.action.GDTInitProvider.1
                        @Override // com.qq.gdt.action.multioprocess.c
                        public void a(com.qq.gdt.action.multioprocess.b bVar3) {
                            if (bVar3 == null) {
                                o.a("save file not null, getUserMessage null", new Object[0]);
                                com.qq.gdt.action.g.a.a(3404);
                            } else {
                                o.a("cp save file not null, memory update getUserMessage =  " + bVar3, new Object[0]);
                                com.qq.gdt.action.multioprocess.d.a().f3099a = bVar3;
                                bundle2.putSerializable("result_user_info", bVar3);
                            }
                        }
                    });
                }
            }
            o.a("cp return bundle = " + bundle2, new Object[0]);
            return bundle2;
        } catch (Throwable th) {
            o.a("bundle call e", th);
            return null;
        }
    }

    @Override // android.content.ContentProvider
    public Bundle call(String str, String str2, String str3, Bundle bundle) {
        return super.call(str, str2, str3, bundle);
    }

    @Override // android.content.ContentProvider
    public int delete(Uri uri, String str, String[] strArr) {
        return 0;
    }

    @Override // android.content.ContentProvider
    public String getType(Uri uri) {
        return null;
    }

    @Override // android.content.ContentProvider
    public Uri insert(Uri uri, ContentValues contentValues) {
        return null;
    }

    @Override // android.content.ContentProvider
    public boolean onCreate() {
        try {
            o.a("GDTInitProvider", "MySDKInitProvider onCreate >>> " + hashCode(), new Object[0]);
            g.a().a(true);
            g.a().f3078a = g.a.CP;
            return true;
        } catch (Exception e) {
            com.qq.gdt.action.g.a.a(1005);
            o.c("GDTInitProvider onCreate e = " + e.toString());
            return true;
        }
    }

    @Override // android.content.ContentProvider
    public Cursor query(Uri uri, String[] strArr, String str, String[] strArr2, String str2) {
        return null;
    }

    @Override // android.content.ContentProvider
    public int update(Uri uri, ContentValues contentValues, String str, String[] strArr) {
        return 0;
    }
}
