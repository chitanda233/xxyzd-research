package cn.thinkingdata.core.sqlite;

import android.database.Cursor;

/* JADX INFO: loaded from: classes.dex */
public interface ITESqliteQueryCallback {
    void onQueryFail();

    void onQuerySuccess(Cursor cursor);
}
